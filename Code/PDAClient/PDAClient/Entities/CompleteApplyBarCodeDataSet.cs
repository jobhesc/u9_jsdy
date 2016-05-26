using PDAClient.PDAService;
using System.Collections.Generic;
using System;
using System.Text;
using PDAClient.Utils;
namespace PDAClient.Entities {
    
    
    public partial class CompleteApplyBarCodeDataSet {
        /// <summary>
        /// 把行记录转化成导入DTO
        /// </summary>
        /// <returns></returns>
        public ProductBarCodeImportDTO[] ToImportDTOs()
        {
            if (this.CompleteApplyBarCode.Rows.Count == 0) return null;

            List<ProductBarCodeImportDTO> importList = new List<ProductBarCodeImportDTO>();
            ProductBarCodeImportDTO importDTO = null;
            foreach (CompleteApplyBarCodeRow completeApplyBarCodeRow in this.CompleteApplyBarCode.Rows)
            {
                importDTO = new ProductBarCodeImportDTO();
                importDTO.ItemID = completeApplyBarCodeRow.ItemID;
                importDTO.OrgID = completeApplyBarCodeRow.OrgID;
                importDTO.Qty = completeApplyBarCodeRow.Qty;
                importDTO.ScanDate = completeApplyBarCodeRow.ScanOn;
                importDTO.ScanPerson = completeApplyBarCodeRow.ScanBy;
                importDTO.BarCode = completeApplyBarCodeRow.BarCode;
                importDTO.DocID = completeApplyBarCodeRow.CompleteApplyDocID;
                importDTO.DocLineID = completeApplyBarCodeRow.CompleteApplyDocLineID;
                importDTO.QcOperatorID = completeApplyBarCodeRow.QcOperatorID;

                importList.Add(importDTO);
            }

            return importList.ToArray();
        }

        partial class CompleteApplyBarCodeDataTable
        {

            /// <summary>
            /// 根据CompleteApplyBarCodeDataTable添加记录
            /// </summary>
            /// <param name="dto"></param>
            /// <param name="moDocNo"></param>
            /// <param name="docID"></param>
            /// <param name="docLineID"></param>
            /// <returns></returns>
            public CompleteApplyBarCodeRow AddNewRow(BarCodeInfoDTO dto, string moDocNo, long docID, long docLineID)
            {
                CompleteApplyBarCodeRow dataRow = this.NewCompleteApplyBarCodeRow();
                // 组织ID
                dataRow.OrgID = PDAContext.LoginOrgID;
                // 料品
                dataRow.ItemID = dto.ItemID;
                dataRow.ItemCode = dto.ItemCode;
                dataRow.ItemName = dto.ItemName;
                dataRow.ItemSPECS = dto.ItemSPECS;
                //条码
                dataRow.BarCode = dto.BarCode;
                //实际长度
                dataRow.Qty = dto.ActualLength;
                //检验员
                dataRow.QcOperatorID = dto.QcOperatorID;
                dataRow.QcOperatorCode = dto.QcOperatorCode;
                // 扫描人
                dataRow.ScanBy = PDAContext.LoginUserName;
                // 扫描日期
                dataRow.ScanOn = DateTime.Now;
                //申报单和申报行
                dataRow.CompleteApplyDocID = docID;
                dataRow.CompleteApplyDocLineID = docLineID;
                //MO
                dataRow.MO = moDocNo;

                this.AddCompleteApplyBarCodeRow(dataRow);

                return dataRow;
            }

        }

        partial class CompleteApplyBarCodeRow
        {

            public string ToString()
            {
                StringBuilder builder = new StringBuilder();
                //条码：
                builder.Append("条码:");
                builder.Append(this.BarCode);
                builder.Append("\r\n");
                //MO
                builder.Append("生产订单:");
                builder.Append(this.MO);
                builder.Append("\r\n");
                //料品
                builder.Append("料品:");
                builder.Append(this.ItemCode);
                builder.Append("|");
                builder.Append(this.ItemName);
                if (!string.IsNullOrEmpty(this.ItemSPECS))
                {
                    builder.Append("|");
                    builder.Append(this.ItemSPECS);
                }
                builder.Append("\r\n");
                //段长
                builder.Append("段长:");
                builder.Append(this.Qty);
                builder.Append("米");

                return builder.ToString();
            }
        }
    }
}

