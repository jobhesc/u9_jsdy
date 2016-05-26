using PDAClient.Entities.InvCheckBarCodeDataSetTableAdapters;
using PDAClient.PDAService;
using System.Collections.Generic;
using PDAClient.Utils;
using System;
using System.Text;
namespace PDAClient.Entities
{

    partial class InvCheckBarCodeDataSet
    {

        /// <summary>
        /// 把行记录转化成导入DTO
        /// </summary>
        /// <returns></returns>
        public InvCheckBarCodeImportDTO[] ToImportDTOs()
        {
            if (this.InvCheckBarCode.Rows.Count == 0) return null;

            List<InvCheckBarCodeImportDTO> importList = new List<InvCheckBarCodeImportDTO>();
            InvCheckBarCodeImportDTO importDTO = null;
            foreach (InvCheckBarCodeRow invCheckBarCodeRow in this.InvCheckBarCode.Rows)
            {
                importDTO = new InvCheckBarCodeImportDTO();
                importDTO.ItemID = invCheckBarCodeRow.ItemID;
                importDTO.OrgID = invCheckBarCodeRow.OrgID;
                importDTO.Qty = invCheckBarCodeRow.Qty;
                importDTO.ScanDate = invCheckBarCodeRow.ScanDate;
                importDTO.ScanPerson = invCheckBarCodeRow.ScanPerson;
                importDTO.BarCode = invCheckBarCodeRow.BarCode;

                importList.Add(importDTO);
            }

            return importList.ToArray();
        }

        partial class InvCheckBarCodeDataTable
        {

            /// <summary>
            /// 根据InvCheckBarCodeDataTable添加记录
            /// </summary>
            /// <param name="dto"></param>
            /// <returns></returns>
            public InvCheckBarCodeRow AddNewRow(BarCodeInfoDTO dto)
            {
                if (dto == null) return null;

                foreach (InvCheckBarCodeRow row in this)
                {
                    if (row.BarCode == dto.BarCode)
                        throw new Exception(string.Format("条码{0}已经扫描，不允许重复扫描", dto.BarCode));
                }

                InvCheckBarCodeRow dataRow = this.NewInvCheckBarCodeRow();
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
                // 扫描人
                dataRow.ScanPerson = PDAContext.LoginUserName;
                // 扫描日期
                dataRow.ScanDate = DateTime.Now;

                this.AddInvCheckBarCodeRow(dataRow);

                return dataRow;
            }

        }

        partial class InvCheckBarCodeRow
        {
            public new string ToString()
            {
                StringBuilder builder = new StringBuilder();

                builder.Append("条码:");
                builder.Append(this.BarCode);
                builder.Append("\r\n");

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

                builder.Append("实际长度:");
                builder.Append(this.Qty);

                return builder.ToString();
            }
        }
    }
}

