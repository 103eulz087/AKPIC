using AForge.Video.DirectShow;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDProject
{
    class Camera
    {
        public static String getDevices()
        {
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            string val = "";
            foreach (FilterInfo device in videoDevices)
            {
                val = device.Name;
            }
            VideoCaptureDevice videoSource = new VideoCaptureDevice();
            return val;
        }
    }
}
