using System;
using System.Management;

namespace SystemInfo
{
    [Serializable]
    public class ProcessorInformation : SystemComponentInformation
    {
        protected override string ComponentCode { get { return "win32_processor"; } }

        protected override void GetComponet()
        {
            ManagementObjectCollection managmentObjects = ManagementClass.GetInstances();
            foreach (ManagementObject item in managmentObjects)
            {
                Processor cpu = new Processor(item);
                _componets.Add(cpu);
            }
        }
    }
}