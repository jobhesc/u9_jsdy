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
        #region IScan ��Ա

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
        /// ��ʼ���豸������
        /// </summary>
        public void Init()
        {
            if (Devices.SupportedDevices == null || Devices.SupportedDevices.Length == 0)
                throw new Exception("û���ҵ�ϵͳ֧�ֵ�����ɨ���豸��");

            barcode2 = new Barcode2(Devices.SupportedDevices[0]);
            switch (barcode2.Config.Reader.ReaderType)
            {
                case READER_TYPES.READER_TYPE_IMAGER:  // ͼ�������ȡ��
                    barcode2.Config.Reader.ReaderSpecific.ImagerSpecific.AimType = AIM_TYPE.AIM_TYPE_TRIGGER;
                    //barcode2.Config.Reader.ReaderSpecific.ImagerSpecific.FocusMode = FOCUS_MODE.FOCUS_MODE_AUTO;
                    //barcode2.Config.Reader.ReaderSpecific.ImagerSpecific.DPMMode = DPM_MODE.DPM_MODE_ENABLED;
                    break;
                case READER_TYPES.READER_TYPE_LASER:  // ���������ȡ��
                    barcode2.Config.Reader.ReaderSpecific.LaserSpecific.AimType = AIM_TYPE.AIM_TYPE_TRIGGER;
                    break;
            }
            
            barcode2.Config.Reader.Set();
        }

        /// <summary>
        /// ����ɨ����֪ͨ�¼��ص�����
        /// </summary>
        /// <param name="ScanNotifyHandler"></param>
        public void AttachScanNotify(Barcode2.OnScanHandler ScanNotifyHandler)
        {
            if (barcode2 != null)
                barcode2.OnScan += ScanNotifyHandler;
        }

        /// <summary>
        /// ��ʼ����ɨ��
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
        /// ����ɨ��
        /// </summary>
        public void StopScan()
        {
            if (barcode2 == null) return;
            barcode2.ScanCancel();
        }

        /// <summary>
        /// �ͷŶ���
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
