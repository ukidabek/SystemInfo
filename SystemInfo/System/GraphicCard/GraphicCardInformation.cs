using System;
using System.Management;

namespace SystemInfo
{
    [Serializable]
    public class GraphicCardInformation : SystemComponentInformation
    {
        protected override string ComponentCode { get { return "Win32_VideoController"; } }

        protected override void GetComponet()
        {
            ManagementObjectCollection managmentObjects = ManagementClass.GetInstances();
            foreach (ManagementObject item in managmentObjects)
            {
                GraphicCard gpu = new GraphicCard(item);
                _componets.Add(gpu);
            }
        }
    }
}