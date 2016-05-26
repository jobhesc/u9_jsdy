using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Security.Cryptography;
using System.Text;
using System.Data;
using System.Collections.Generic;
using JSDY.U9SV.Utils;
using JSDY.U9SV;
using System.Transactions;
using JSDY.U9SV.Version;
using JSDY.U9SV.DTO;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class U9PDAService : System.Web.Services.WebService
{
    public U9PDAService()
    {
        //如果使用设计的组件，请取消注释以下行 
        //InitializeComponent(); 
    }

    #region 登录校验服务

    /// <summary>
    /// 登录校验
    /// </summary>
    /// <param name="user"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    [WebMethod]
    public bool LoginValidate(string user, string password)
    {
        try
        {
            if (string.IsNullOrEmpty(user)) return false;
            string sql = string.Format("select Password from Base_User where Code='{0}'", user);
            string pwd = TypeHelper.ConvertType<string>(SQLHelper.ExecuteScalar(sql), string.Empty);
            return pwd == MD5Encrypt(password);
        }
        catch (Exception ex)
        {
            PDALog.Error(ex);
            throw ExceptionHelper.CreateSoapException(ex.Message, ex.Source);
        }
    }

    /// <summary>
    /// 对字符串进行MD加密
    /// </summary>
    /// <param name="source"></param>
    /// <returns></returns>
    private string MD5Encrypt(string source)
    {
        MD5 md = MD5.Create();
        byte[] bytes = new UnicodeEncoding().GetBytes(source);
        return Convert.ToBase64String(md.ComputeHash(bytes));
    }

    #endregion

    #region 修改密码服务

    /// <summary>
    /// 登录校验
    /// </summary>
    /// <param name="user"></param>
    /// <param name="newPassword"></param>
    /// <returns></returns>
    [WebMethod]
    public void ChangePassword(string user, string newPassword)
    {
        try
        {
            if (string.IsNullOrEmpty(user)) return;
            string sql = string.Format("update Base_User set Password='{0}' where Code='{1}'", MD5Encrypt(newPassword), user);
            SQLHelper.ExecuteNonQuery(sql);
        }
        catch (Exception ex)
        {
            PDALog.Error(ex);
            throw ExceptionHelper.CreateSoapException(ex.Message, ex.Source);
        }
    }

    #endregion

    #region 版本更新

    /// <summary>
    /// 判断是否需要更新版本
    /// </summary>
    /// <param name="clientVersion"></param>
    /// <returns></returns>
    [WebMethod]
    public bool IsNeedUpdateVersion(string version)
    {
        if (string.IsNullOrEmpty(version))
            throw new ArgumentException("传入的版本参数为空！");
        // 客户端是否自动更新
        if (!IsAutoUpdateClient()) return false;

        string lastestVersion = PDAConfig.GetPatchVersion();
        if (string.IsNullOrEmpty(lastestVersion)) return false;

        // 最新版本
        Version serverVersion = new Version(lastestVersion);
        // 客户端版本
        Version clientVersion = new Version(version);

        // 主版本比较
        if (serverVersion.Major > clientVersion.Major) return true;
        if (serverVersion.Major < clientVersion.Major) return false;
        // 小版本比较
        if (serverVersion.Minor > clientVersion.Minor) return true;
        if (serverVersion.Minor < clientVersion.Minor) return false;
        // build号比较
        if (serverVersion.Build > clientVersion.Build) return true;
        if (serverVersion.Build < clientVersion.Build) return false;
        // Revision号比较
        if (serverVersion.Revision > clientVersion.Revision) return true;
        if (serverVersion.Revision < clientVersion.Revision) return false;

        return false;
    }

    /// <summary>
    /// 获取补丁下载路径
    /// </summary>
    /// <returns></returns>
    [WebMethod]
    public List<VersionItem> GetPatchDownloads()
    {
        return PDAConfig.GetPatchDownloads();
    }

    #endregion

    #region 查询基础信息

    /// <summary>
    /// 是否通过异步方式生单
    /// </summary>
    /// <param name="orgID"></param>
    /// <returns></returns>
    private bool IsGenBillWithJob(long orgID)
    {
        return TypeHelper.ConvertType<bool>(GetProfileValue(orgID, "Cust_IsJobRunBarCodeGenBill"), false);
    }

    /// <summary>
    /// 客户端是否自动更新
    /// </summary>
    /// <returns></returns>
    private bool IsAutoUpdateClient()
    {
        return TypeHelper.ConvertType<bool>(GetProfileValue(0, "Cust_IsClientAutoUpdate"), false);
    }

    /// <summary>
    /// 获取参数值
    /// </summary>
    /// <param name="orgID"></param>
    /// <returns></returns>
    private object GetProfileValue(long orgID, string profileCode)
    {
        string sql = string.Format(@"
select profileValue.Value 
from Base_ProfileValue as profileValue
inner join Base_Profile as profiles on profileValue.[Profile] = profiles.ID
where profiles.Code='{0}'", profileCode);

        if (orgID > 0)
            sql += " and profileValue.Organization=" + orgID;

        return SQLHelper.ExecuteScalar(sql);

    }

    /// <summary>
    /// 查询用户信息
    /// </summary>
    /// <param name="userCode"></param>
    /// <returns></returns>
    [WebMethod]
    public UserInfoDTO QueryUserInfo(string userCode)
    {
        try
        {
            string sql = string.Format("select ID, Code, Name from Base_User where Code='{0}'", userCode);

            DataSet dataSet = SQLHelper.ExecuteDataSet(sql);
            if (dataSet == null || dataSet.Tables.Count == 0 || dataSet.Tables[0].Rows.Count == 0) return null;
            DataRow dataRow = dataSet.Tables[0].Rows[0];

            UserInfoDTO userInfoDTO = new UserInfoDTO();
            userInfoDTO.UserID = TypeHelper.ConvertType<long>(dataRow["ID"], 0);
            userInfoDTO.UserCode = TypeHelper.ConvertType<string>(dataRow["Code"], string.Empty);
            userInfoDTO.UserName = TypeHelper.ConvertType<string>(dataRow["Name"], string.Empty);

            return userInfoDTO;
        }
        catch (Exception ex)
        {
            PDALog.Error(ex);
            throw ExceptionHelper.CreateSoapException(ex.Message, ex.Source);
        }
    }

    /// <summary>
    /// 查询组织信息
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    [WebMethod]
    public List<OrgInfoDTO> QueryOrgInfo(string user)
    {
        try
        {
            string sql = string.Format(@"
select distinct org.ID as OrgID,
	org.Code as OrgCode,
	orgTrl.Name as OrgName 
from Base_UserOrg as userOrg
inner join Base_User as users on users.ID=userOrg.[User]
inner join Base_Organization as org on userOrg.Org=org.ID
inner join Base_Organization_Trl as orgTrl on org.ID=orgTrl.ID and orgTrl.SysMLFlag='zh-CN'
where org.ID not in (101, 102) 
	and org.Effective_IsEffective=1 
	and org.Effective_EffectiveDate<='{0}'
	and org.Effective_DisableDate>='{0}'
    and users.Code='{1}'", DateTime.Now.Date, user);

            DataSet dataSet = SQLHelper.ExecuteDataSet(sql);
            if (dataSet == null || dataSet.Tables.Count == 0 || dataSet.Tables[0].Rows.Count == 0) return null;

            List<OrgInfoDTO> orgInfoList = new List<OrgInfoDTO>();
            OrgInfoDTO orgInfoDTO = null;

            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                orgInfoDTO = new OrgInfoDTO();
                orgInfoDTO.OrgID = TypeHelper.ConvertType<long>(dataRow["OrgID"], 0);
                orgInfoDTO.OrgCode = TypeHelper.ConvertType<string>(dataRow["OrgCode"], string.Empty);
                orgInfoDTO.OrgName = TypeHelper.ConvertType<string>(dataRow["OrgName"], string.Empty);
                orgInfoList.Add(orgInfoDTO);
            }

            return orgInfoList;

        }
        catch (Exception ex)
        {
            PDALog.Error(ex);
            throw ExceptionHelper.CreateSoapException(ex.Message, ex.Source);
        }
    }

    #endregion

    #region 查询条码信息

    /// <summary>
    /// 查询完工申报单信息
    /// </summary>
    /// <param name="orgID"></param>
    /// <param name="barCode"></param>
    /// <returns></returns>
    [WebMethod]
    public List<CompleteApplyDocDTO> QueryCompleteApplyDocInfo(long orgID, string barCode)
    {
        try
        {
            if (string.IsNullOrEmpty(barCode)) return null;

            string sql = string.Format(@"
select *, (case when a.SegLength=0 then 0 else a.TotalLength/a.SegLength end)-a.RcvCount as JCount
from(
	select mo.ID as MOID,
		mo.DocNo as MODocNo,
		item.ID as ItemID,
		item.Code as ItemCode,
		item.Name as ItemName,
		item.SPECS as ItemSPECS,
		doc.ID as CompleteApplyDocID,
		line.ID as CompleteApplyLineID,
		convert(decimal(24,9), (case when line.DescFlexField_PubDescSeg1='' then '0' else line.DescFlexField_PubDescSeg1 end)) as SegLength,
		line.CompleteQty*1000 as TotalLength,
		convert(decimal(24,9), (case when line.DescFlexField_PrivateDescSeg2='' then '0' else line.DescFlexField_PrivateDescSeg2 end)) as RcvCount
	from Complete_CompleteApplyDocLine as line
	inner join CBO_ItemMaster as item on line.Item=item.ID
	inner join MO_MO as mo on line.MO=mo.ID
	inner join Complete_CompleteApplyDoc as doc on line.CompleteApplyDoc=doc.ID
	where doc.Org='{0}' and doc.DocNo='{1}'
) as a where a.SegLength>0 and a.RcvCount<(a.TotalLength/a.SegLength) ", orgID, barCode);

            DataSet dataSet = SQLHelper.ExecuteDataSet(sql);
            if (dataSet == null || dataSet.Tables.Count == 0 || dataSet.Tables[0].Rows.Count == 0) return null;

            List<CompleteApplyDocDTO> resultList = new List<CompleteApplyDocDTO>();
            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                CompleteApplyDocDTO dto = new CompleteApplyDocDTO();
                dto.ItemID = TypeHelper.ConvertType<long>(dataRow["ItemID"], 0);
                dto.ItemCode = TypeHelper.ConvertType<string>(dataRow["ItemCode"], string.Empty);
                dto.ItemName = TypeHelper.ConvertType<string>(dataRow["ItemName"], string.Empty);
                dto.ItemSPECS = TypeHelper.ConvertType<string>(dataRow["ItemSPECS"], string.Empty);

                dto.MO = TypeHelper.ConvertType<long>(dataRow["MOID"], 0);
                dto.MoDocNo = TypeHelper.ConvertType<string>(dataRow["MODocNo"], string.Empty);
                dto.CompleteApplyDocID = TypeHelper.ConvertType<long>(dataRow["CompleteApplyDocID"], 0);
                dto.CompleteApplyLineID = TypeHelper.ConvertType<long>(dataRow["CompleteApplyLineID"], 0);

                dto.SegLength = (int)TypeHelper.ConvertType<decimal>(dataRow["SegLength"], 0);
                dto.Count = (int)TypeHelper.ConvertType<decimal>(dataRow["JCount"], 0);
                dto.TotalLength = (int)TypeHelper.ConvertType<decimal>(dataRow["TotalLength"], 0);
                resultList.Add(dto);
            }
            return resultList;
        }
        catch (Exception ex)
        {
            PDALog.Error(ex);
            throw ExceptionHelper.CreateSoapException(ex.Message, ex.Source);
        }
    }

    /// <summary>
    /// 查询出货计划信息
    /// </summary>
    /// <param name="orgID"></param>
    /// <param name="barCode"></param>
    /// <returns></returns>
    [WebMethod]
    public List<ShipPlanDocDTO> QueryShipPlanDocInfo(long orgID, string barCode)
    {
        try
        {
            if (string.IsNullOrEmpty(barCode)) return null;

            string sql = string.Format(@"
select *, (case when a.SegLength=0 then 0 else a.TotalLength/a.SegLength end)-a.RcvCount as JCount
from(
	select item.ID as ItemID,
		item.Code as ItemCode,
		item.Name as ItemName,
		item.SPECS as ItemSPECS,
		doc.ID as ShipPlanID,
		line.ID as ShipPlanLineID,
		convert(decimal(24,9), (case when line.DescFlexField_PubDescSeg1='' then '0' else line.DescFlexField_PubDescSeg1 end)) as SegLength,
		line.PlanQtyTU*1000 as TotalLength,
		convert(decimal(24,9), (case when line.DescFlexField_PrivateDescSeg2='' then '0' else line.DescFlexField_PrivateDescSeg2 end)) as RcvCount
	from SM_ShipPlanLine as line
	inner join CBO_ItemMaster as item on line.ItemInfo_ItemID=item.ID
	inner join SM_ShipPlan as doc on line.ShipPlan=doc.ID
	where doc.Org='{0}' and doc.DocNo='{1}'
) as a where a.SegLength>0 and a.RcvCount<(a.TotalLength/a.SegLength)", orgID, barCode);

            DataSet dataSet = SQLHelper.ExecuteDataSet(sql);
            if (dataSet == null || dataSet.Tables.Count == 0 || dataSet.Tables[0].Rows.Count == 0) return null;

            List<ShipPlanDocDTO> resultList = new List<ShipPlanDocDTO>();
            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                ShipPlanDocDTO dto = new ShipPlanDocDTO();
                dto.ItemID = TypeHelper.ConvertType<long>(dataRow["ItemID"], 0);
                dto.ItemCode = TypeHelper.ConvertType<string>(dataRow["ItemCode"], string.Empty);
                dto.ItemName = TypeHelper.ConvertType<string>(dataRow["ItemName"], string.Empty);
                dto.ItemSPECS = TypeHelper.ConvertType<string>(dataRow["ItemSPECS"], string.Empty);

                dto.ShipPlanID = TypeHelper.ConvertType<long>(dataRow["ShipPlanID"], 0);
                dto.ShipPlanLineID = TypeHelper.ConvertType<long>(dataRow["ShipPlanLineID"], 0);

                dto.SegLength = (int)TypeHelper.ConvertType<decimal>(dataRow["SegLength"], 0);
                dto.Count = (int)TypeHelper.ConvertType<decimal>(dataRow["JCount"], 0);
                dto.TotalLength = (int)TypeHelper.ConvertType<decimal>(dataRow["TotalLength"], 0);
                resultList.Add(dto);
            }
            return resultList;
        }
        catch (Exception ex)
        {
            PDALog.Error(ex);
            throw ExceptionHelper.CreateSoapException(ex.Message, ex.Source);
        }
    }

    /// <summary>
    /// 查询条码信息
    /// </summary>
    /// <param name="orgID"></param>
    /// <param name="barCode"></param>
    /// <returns></returns>
    [WebMethod]
    public BarCodeInfoDTO QueryBarCodeInfo(long orgID, string barCode)
    {
        try
        {
            if (string.IsNullOrEmpty(barCode)) return null;

            string sql = string.Format(@"
select barcode.BarCode,
	barcode.Item as ItemID, 
	item.Code as ItemCode, 
	item.Name as ItemName, 
	item.SPECS as ItemSPECS,
	item.DescFlexField_PrivateDescSeg1 as ItemCheckStandard,
    barcode.ActualLength,
    ISNULL(op.ID, 0) as opID,
	ISNULL(op.Code,'') as opCode
from Cust_CompleteApplyBarCode as barcode 
left join CBO_ItemMaster as item on barcode.Item = item.ID
left join CBO_Operators as op on barcode.Operators = op.ID
where barcode.BarCode='{0}' and barcode.Org='{1}' ", barCode, orgID);

            DataSet dataSet = SQLHelper.ExecuteDataSet(sql);
            if (dataSet == null || dataSet.Tables.Count == 0 || dataSet.Tables[0].Rows.Count == 0) return null;

            DataRow dataRow = dataSet.Tables[0].Rows[0];
            BarCodeInfoDTO dto = new BarCodeInfoDTO();
            dto.ItemID = TypeHelper.ConvertType<long>(dataRow["ItemID"], 0);
            dto.ItemCode = TypeHelper.ConvertType<string>(dataRow["ItemCode"], string.Empty);
            dto.ItemName = TypeHelper.ConvertType<string>(dataRow["ItemName"], string.Empty);
            dto.ItemSPECS = TypeHelper.ConvertType<string>(dataRow["ItemSPECS"], string.Empty);
            dto.BarCode = TypeHelper.ConvertType<string>(dataRow["BarCode"], string.Empty);
            dto.ActualLength = TypeHelper.ConvertType<int>(dataRow["ActualLength"], 0);
            dto.ItemCheckStandard = TypeHelper.ConvertType<string>(dataRow["ItemCheckStandard"], string.Empty);
            dto.QcOperatorID = TypeHelper.ConvertType<long>(dataRow["opID"], 0);
            dto.QcOperatorCode = TypeHelper.ConvertType<string>(dataRow["opCode"], string.Empty);
            return dto;
        }
        catch (Exception ex)
        {
            PDALog.Error(ex);
            throw ExceptionHelper.CreateSoapException(ex.Message, ex.Source);
        }
    }

    #endregion

    #region 生成盘点条码记录

    /// <summary>
    /// 生成条形码记录，需要把webservice设计成具有幂等性(即不管调用多少次该接口，
    /// 返回的结果是一样的，不会因为网络环境问题导致多生成了记录)
    /// </summary>
    /// <param name="importDTOs"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    [WebMethod]
    public List<long> AddInvCheckBarCodes(List<InvCheckBarCodeImportDTO> importDTOs, LoginContext context)
    {
        if (importDTOs == null || importDTOs.Count == 0) return null;

        try
        {
            U9SVHandler.genCheckBarCodes(importDTOs, context);
            return null;
        }
        catch (Exception ex)
        {
            PDALog.Error(ex);
            throw ExceptionHelper.CreateSoapException(ex.Message, ex.Source);
        }
    }

    #endregion

    #region 根据完工申报单生成成品条码记录

    /// <summary>
    /// 生成条形码记录，需要把webservice设计成具有幂等性(即不管调用多少次该接口，
    /// 返回的结果是一样的，不会因为网络环境问题导致多生成了记录)
    /// </summary>
    /// <param name="importDTOs"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    [WebMethod]
    public List<long> AddProductBarCodesByCompleteApply(List<ProductBarCodeImportDTO> importDTOs, LoginContext context)
    {
        if (importDTOs == null || importDTOs.Count == 0) return null;

        try
        {
            U9SVHandler.genProductBarCodeByCompleteApply(importDTOs, context);
            return null;
        }
        catch (Exception ex)
        {
            PDALog.Error(ex);
            throw ExceptionHelper.CreateSoapException(ex.Message, ex.Source);
        }
    }

    #endregion

    #region 根据出货计划生成成品条码记录

    /// <summary>
    /// 生成条形码记录，需要把webservice设计成具有幂等性(即不管调用多少次该接口，
    /// 返回的结果是一样的，不会因为网络环境问题导致多生成了记录)
    /// </summary>
    /// <param name="importDTOs"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    [WebMethod]
    public List<long> AddProductBarCodesByShip(List<ProductBarCodeImportDTO> importDTOs, LoginContext context)
    {
        if (importDTOs == null || importDTOs.Count == 0) return null;

        try
        {
            U9SVHandler.genProductBarCodeByShip(importDTOs, context);
            return null;
        }
        catch (Exception ex)
        {
            PDALog.Error(ex);
            throw ExceptionHelper.CreateSoapException(ex.Message, ex.Source);
        }
    }

    #endregion

}
