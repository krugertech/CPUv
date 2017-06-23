using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Simplified.Environment
{
    internal class WmiController
    {
        public static CpuCollection GetCpus()
        {
            CpuCollection cpus = new CpuCollection();
            try
            {
                using (var searcher = new ManagementObjectSearcher("SELECT DeviceID, ProcessorId, Name, Manufacturer, Description, LoadPercentage, CurrentClockSpeed, MaxClockSpeed, CurrentVoltage, NumberOfCores, NumberOfLogicalProcessors FROM Win32_Processor"))
                {
                    int altIndex = 0;
                    foreach (ManagementBaseObject sys in searcher.Get())
                    {
                        var cpu = new Cpu();
                        try
                        {
                            cpu.Index = int.Parse(sys["DeviceID"].ToString().Substring(2));
                        }
                        catch
                        {
                            cpu.Index = altIndex;
                        }
                        cpu.ProcessorId = sys["DeviceID"].ToString();
                        cpu.Name = sys["Name"].ToString();
                        cpu.Manufacturer = sys["Manufacturer"].ToString();
                        cpu.Description = sys["Description"].ToString();

                        cpu.LoadPercentage = int.Parse(sys["LoadPercentage"].ToString());
                        cpu.CurrentClockSpeed = int.Parse(sys["CurrentClockSpeed"].ToString());
                        cpu.MaxClockSpeed = int.Parse(sys["MaxClockSpeed"].ToString());
                        cpu.CurrentVoltage = int.Parse(sys["CurrentVoltage"].ToString());

                        cpu.CoreCount = int.Parse(sys["NumberOfCores"].ToString());
                        cpu.LogicalCoreCount = int.Parse(sys["NumberOfLogicalProcessors"].ToString());

                        cpus.Add(cpu);

                        altIndex++;                        
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error retrieving cpu properties. " + ex.Message);
            }

            return cpus;
        }
    }
}
