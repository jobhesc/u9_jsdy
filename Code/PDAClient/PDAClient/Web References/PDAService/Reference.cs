﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.5420
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.CompactFramework.Design.Data 2.0.50727.5420 版自动生成。
// 
namespace PDAClient.PDAService {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="U9PDAServiceSoap", Namespace="http://tempuri.org/")]
    public partial class U9PDAService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public U9PDAService() {
            this.Url = "http://localhost/PDAService/U9PDAService.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/LoginValidate", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool LoginValidate(string user, string password) {
            object[] results = this.Invoke("LoginValidate", new object[] {
                        user,
                        password});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginLoginValidate(string user, string password, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("LoginValidate", new object[] {
                        user,
                        password}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndLoginValidate(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ChangePassword", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ChangePassword(string user, string newPassword) {
            this.Invoke("ChangePassword", new object[] {
                        user,
                        newPassword});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginChangePassword(string user, string newPassword, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ChangePassword", new object[] {
                        user,
                        newPassword}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndChangePassword(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IsNeedUpdateVersion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool IsNeedUpdateVersion(string version) {
            object[] results = this.Invoke("IsNeedUpdateVersion", new object[] {
                        version});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginIsNeedUpdateVersion(string version, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("IsNeedUpdateVersion", new object[] {
                        version}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndIsNeedUpdateVersion(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetPatchDownloads", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public VersionItem[] GetPatchDownloads() {
            object[] results = this.Invoke("GetPatchDownloads", new object[0]);
            return ((VersionItem[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetPatchDownloads(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetPatchDownloads", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public VersionItem[] EndGetPatchDownloads(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((VersionItem[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/QueryUserInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public UserInfoDTO QueryUserInfo(string userCode) {
            object[] results = this.Invoke("QueryUserInfo", new object[] {
                        userCode});
            return ((UserInfoDTO)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginQueryUserInfo(string userCode, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("QueryUserInfo", new object[] {
                        userCode}, callback, asyncState);
        }
        
        /// <remarks/>
        public UserInfoDTO EndQueryUserInfo(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((UserInfoDTO)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/QueryOrgInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public OrgInfoDTO[] QueryOrgInfo(string user) {
            object[] results = this.Invoke("QueryOrgInfo", new object[] {
                        user});
            return ((OrgInfoDTO[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginQueryOrgInfo(string user, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("QueryOrgInfo", new object[] {
                        user}, callback, asyncState);
        }
        
        /// <remarks/>
        public OrgInfoDTO[] EndQueryOrgInfo(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((OrgInfoDTO[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/QueryCompleteApplyDocInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CompleteApplyDocDTO[] QueryCompleteApplyDocInfo(long orgID, string barCode) {
            object[] results = this.Invoke("QueryCompleteApplyDocInfo", new object[] {
                        orgID,
                        barCode});
            return ((CompleteApplyDocDTO[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginQueryCompleteApplyDocInfo(long orgID, string barCode, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("QueryCompleteApplyDocInfo", new object[] {
                        orgID,
                        barCode}, callback, asyncState);
        }
        
        /// <remarks/>
        public CompleteApplyDocDTO[] EndQueryCompleteApplyDocInfo(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((CompleteApplyDocDTO[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/QueryShipPlanDocInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ShipPlanDocDTO[] QueryShipPlanDocInfo(long orgID, string barCode) {
            object[] results = this.Invoke("QueryShipPlanDocInfo", new object[] {
                        orgID,
                        barCode});
            return ((ShipPlanDocDTO[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginQueryShipPlanDocInfo(long orgID, string barCode, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("QueryShipPlanDocInfo", new object[] {
                        orgID,
                        barCode}, callback, asyncState);
        }
        
        /// <remarks/>
        public ShipPlanDocDTO[] EndQueryShipPlanDocInfo(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((ShipPlanDocDTO[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/QueryBarCodeInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public BarCodeInfoDTO QueryBarCodeInfo(long orgID, string barCode) {
            object[] results = this.Invoke("QueryBarCodeInfo", new object[] {
                        orgID,
                        barCode});
            return ((BarCodeInfoDTO)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginQueryBarCodeInfo(long orgID, string barCode, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("QueryBarCodeInfo", new object[] {
                        orgID,
                        barCode}, callback, asyncState);
        }
        
        /// <remarks/>
        public BarCodeInfoDTO EndQueryBarCodeInfo(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((BarCodeInfoDTO)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddInvCheckBarCodes", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public long[] AddInvCheckBarCodes(InvCheckBarCodeImportDTO[] importDTOs, LoginContext context) {
            object[] results = this.Invoke("AddInvCheckBarCodes", new object[] {
                        importDTOs,
                        context});
            return ((long[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginAddInvCheckBarCodes(InvCheckBarCodeImportDTO[] importDTOs, LoginContext context, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("AddInvCheckBarCodes", new object[] {
                        importDTOs,
                        context}, callback, asyncState);
        }
        
        /// <remarks/>
        public long[] EndAddInvCheckBarCodes(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((long[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddProductBarCodesByCompleteApply", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public long[] AddProductBarCodesByCompleteApply(ProductBarCodeImportDTO[] importDTOs, LoginContext context) {
            object[] results = this.Invoke("AddProductBarCodesByCompleteApply", new object[] {
                        importDTOs,
                        context});
            return ((long[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginAddProductBarCodesByCompleteApply(ProductBarCodeImportDTO[] importDTOs, LoginContext context, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("AddProductBarCodesByCompleteApply", new object[] {
                        importDTOs,
                        context}, callback, asyncState);
        }
        
        /// <remarks/>
        public long[] EndAddProductBarCodesByCompleteApply(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((long[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddProductBarCodesByShip", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public long[] AddProductBarCodesByShip(ProductBarCodeImportDTO[] importDTOs, LoginContext context) {
            object[] results = this.Invoke("AddProductBarCodesByShip", new object[] {
                        importDTOs,
                        context});
            return ((long[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginAddProductBarCodesByShip(ProductBarCodeImportDTO[] importDTOs, LoginContext context, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("AddProductBarCodesByShip", new object[] {
                        importDTOs,
                        context}, callback, asyncState);
        }
        
        /// <remarks/>
        public long[] EndAddProductBarCodesByShip(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((long[])(results[0]));
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class VersionItem {
        
        /// <remarks/>
        public string Version;
        
        /// <remarks/>
        public string DownloadFile;
        
        /// <remarks/>
        public string InstallStyle;
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ProductBarCodeImportDTO {
        
        /// <remarks/>
        public long ItemID;
        
        /// <remarks/>
        public long OrgID;
        
        /// <remarks/>
        public int Qty;
        
        /// <remarks/>
        public System.DateTime ScanDate;
        
        /// <remarks/>
        public string ScanPerson;
        
        /// <remarks/>
        public string BarCode;
        
        /// <remarks/>
        public long QcOperatorID;
        
        /// <remarks/>
        public long DocID;
        
        /// <remarks/>
        public long DocLineID;
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class LoginContext {
        
        /// <remarks/>
        public long OrgID;
        
        /// <remarks/>
        public long UserID;
        
        /// <remarks/>
        public string UserName;
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class InvCheckBarCodeImportDTO {
        
        /// <remarks/>
        public long ItemID;
        
        /// <remarks/>
        public long OrgID;
        
        /// <remarks/>
        public int Qty;
        
        /// <remarks/>
        public System.DateTime ScanDate;
        
        /// <remarks/>
        public string ScanPerson;
        
        /// <remarks/>
        public string BarCode;
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class BarCodeInfoDTO {
        
        /// <remarks/>
        public long ItemID;
        
        /// <remarks/>
        public string ItemCode;
        
        /// <remarks/>
        public string ItemName;
        
        /// <remarks/>
        public string ItemSPECS;
        
        /// <remarks/>
        public string ItemCheckStandard;
        
        /// <remarks/>
        public int ActualLength;
        
        /// <remarks/>
        public long QcOperatorID;
        
        /// <remarks/>
        public string QcOperatorCode;
        
        /// <remarks/>
        public string BarCode;
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ShipPlanDocDTO {
        
        /// <remarks/>
        public long ItemID;
        
        /// <remarks/>
        public string ItemCode;
        
        /// <remarks/>
        public string ItemName;
        
        /// <remarks/>
        public string ItemSPECS;
        
        /// <remarks/>
        public long ShipPlanID;
        
        /// <remarks/>
        public long ShipPlanLineID;
        
        /// <remarks/>
        public int SegLength;
        
        /// <remarks/>
        public int Count;
        
        /// <remarks/>
        public int TotalLength;
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class CompleteApplyDocDTO {
        
        /// <remarks/>
        public long MO;
        
        /// <remarks/>
        public string MoDocNo;
        
        /// <remarks/>
        public long ItemID;
        
        /// <remarks/>
        public string ItemCode;
        
        /// <remarks/>
        public string ItemName;
        
        /// <remarks/>
        public string ItemSPECS;
        
        /// <remarks/>
        public long CompleteApplyDocID;
        
        /// <remarks/>
        public long CompleteApplyLineID;
        
        /// <remarks/>
        public int SegLength;
        
        /// <remarks/>
        public int Count;
        
        /// <remarks/>
        public int TotalLength;
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class OrgInfoDTO {
        
        /// <remarks/>
        public long OrgID;
        
        /// <remarks/>
        public string OrgCode;
        
        /// <remarks/>
        public string OrgName;
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class UserInfoDTO {
        
        /// <remarks/>
        public long UserID;
        
        /// <remarks/>
        public string UserCode;
        
        /// <remarks/>
        public string UserName;
    }
}
