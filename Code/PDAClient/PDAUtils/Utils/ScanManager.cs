using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.WindowsCE.Forms;
using System.IO;
using System.Reflection;
using Symbol.Barcode2;

namespace PDAClient.Utils
{
    public interface IScan
    {
        void Init();
        void StartScan();
        void StopScan();
        void DoDispose();
        void AttachScanNotify(Barcode2.OnScanHandler ScanNotifyHandler);
    }

    public class ScanFactory
    {
        public static IScan CreateScan()
        {
            return new ScanManager();
        }
    }

    public class NullScan : IScan
    {
        #region IScan 成员

        public void Init()
        {
            
        }

        public void StartScan()
        {
            
        }

        public void StopScan()
        {
            
        }

        public void DoDispose()
        {
            
        }

        public void AttachScanNotify(Barcode2.OnScanHandler ScanNotifyHandler)
        {
            
        }

        #endregion
    }

    public class ScanManager : IScan
    {
        /// <summary>
        /// 初始化设备和数据
        /// </summary>
        public void Init()
        {
            if (Devices.SupportedDevices == null || Devices.SupportedDevices.Length == 0)
                throw new Exception("没有找到系统支持的条码扫描设备！");

            barcode2 = new Barcode2(Devices.SupportedDevices[0]);
            switch (barcode2.Config.Reader.ReaderType)
            {
                case READER_TYPES.READER_TYPE_IMAGER:  // 图像条码读取器
                    barcode2.Config.Reader.ReaderSpecific.ImagerSpecific.AimType = AIM_TYPE.AIM_TYPE_TRIGGER;
                    //barcode2.Config.Reader.ReaderSpecific.ImagerSpecific.FocusMode = FOCUS_MODE.FOCUS_MODE_AUTO;
                    //barcode2.Config.Reader.ReaderSpecific.ImagerSpecific.DPMMode = DPM_MODE.DPM_MODE_ENABLED;
                    break;
                case READER_TYPES.READER_TYPE_LASER:  // 激光条码读取器
                    barcode2.Config.Reader.ReaderSpecific.LaserSpecific.AimType = AIM_TYPE.AIM_TYPE_TRIGGER;
                    break;
            }
            
            barcode2.Config.Reader.Set();
        }

        /// <summary>
        /// 附加扫描结果通知事件回调函数
        /// </summary>
        /// <param name="ScanNotifyHandler"></param>
        public void AttachScanNotify(Barcode2.OnScanHandler ScanNotifyHandler)
        {
            if (barcode2 != null)
                barcode2.OnScan += ScanNotifyHandler;
        }

        /// <summary>
        /// 开始进行扫描
        /// </summary>
        public void StartScan()
        {
            if (barcode2 == null) return;

            barcode2.Config.TriggerMode = TRIGGERMODES.HARD;
            barcode2.Config.ScanDataSize = (int)(ReaderDataLengths.MaximumLabel);
            // Submit a scan.
            barcode2.Scan(5000);
        }

        /// <summary>
        /// 结束扫描
        /// </summary>
        public void StopScan()
        {
            if (barcode2 == null) return;
            barcode2.ScanCancel();
        }

        /// <summary>
        /// 释放对象
        /// </summary>
        public void DoDispose()
        {
            if (barcode2 == null) return;
            StopScan();
            barcode2.Dispose();
            barcode2 = null;
        }

        private Barcode2 barcode2 = null;
    }
}
