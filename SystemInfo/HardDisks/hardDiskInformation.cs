﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace SystemInfo
{
    [Serializable]
    public class HardDiskInformation : SystemComponentInformation
    {
        protected override string ComponentCode { get { return "Win32_DiskDrive"; } }

        protected override void GetComponet()
        {
            ManagementObjectCollection managmentObjects = ManagementClass.GetInstances();
            foreach (ManagementObject item in managmentObjects)
            {
                HardDisk mbo = new HardDisk(item);
                _componets.Add(mbo);
            }
        }
    }
}
