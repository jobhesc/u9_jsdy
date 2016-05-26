using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFIDA.U9.Lot;
using UFIDA.U9.CBO.SCM.Item;
using UFIDA.U9.CBO.SCM.Lot;
using UFIDA.U9.CBO.SCM.PropertyTypes;

namespace UFIDA.U9.Cust.JSDY.BarCodeSV.BarCodeSV
{
    class LotBuilder
    {
        /// <summary>
        /// 生成批号
        /// </summary>
        /// <param name="item"></param>
        /// <param name="lotCode"></param>
        /// <param name="actualLength"></param>
        public static LotMaster.EntityKey CreateLot(ItemMaster item, string lotCode, int actualLength)
        {
            if (item.InventoryInfo.LotParamKey == null)
                throw new Exception(string.Format("料品{0}没有启用批号管理，不能生成批号档案！", item.Code));

            LotMaster lot = LotMaster.Finder.Find(string.Format("LotCode='{0}'and ItemCode = '{1}' ", lotCode, item.Code));
            if (lot != null)
                return lot.Key;

            // 生成批号主挡
            LotRequestDTO lotReqDTO = new LotRequestDTO();
            lotReqDTO.Item = item.Key;
            //lotReqDTO.ItemCode = item.Code;
            lotReqDTO.ItemOrg = item.OrgKey;
            lotReqDTO.QueryTime = Base.Context.LoginDateTime;
            lotReqDTO.UsingOrg = Base.Context.LoginOrg.Key;
            lotReqDTO.Lot = lotCode;

            lotReqDTO.EffectiveTime = Base.Context.LoginDate;
            lotReqDTO.InvalidTime = DateTime.Parse("3000-1-1");
            lotReqDTO.ValidDays = (lotReqDTO.InvalidTime - lotReqDTO.EffectiveTime).Days;
            //段长
            lotReqDTO.DescFlexSegments = new Base.FlexField.DescFlexField.DescFlexSegments();
            lotReqDTO.DescFlexSegments.PubDescSeg1 = actualLength.ToString();

            CreateLotOnlineSV onlineLot = new CreateLotOnlineSV();
            onlineLot.LotRequestDTO = lotReqDTO;
            LotInfo lotInfo = onlineLot.Do();
            if (lotInfo == null) return null;
            if (lotInfo.LotMaster == null) return null;
            if (lotInfo.LotMaster.EntityID <= 0L) return null;
            return new LotMaster.EntityKey(lotInfo.LotMaster.EntityID);
        }
    }
}
