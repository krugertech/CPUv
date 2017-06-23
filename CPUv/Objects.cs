using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplified.Environment
{
    public class LogicalCore
    {
        public string Name { get; set; }
        public int PercentageUsage { get; set; }
    }

    public class Cpu
    {
        public int Index { get; set; }
        public string ProcessorId { get; set; }

        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }

        public int LoadPercentage { get; set; }
        public int CurrentClockSpeed { get; set; }
        public int MaxClockSpeed { get; set; }
        public int CurrentVoltage { get; set; }

        public int CoreCount { get; set; }
        public int LogicalCoreCount { get; set; }
    }

    public class CpuCollection : List<Cpu>
    {
        public int TotalCpu => this.Count;

        public int TotalCores
        {
            get { return this.Sum(c => c.CoreCount); }
        }

        public int TotalLogicalCores
        {
            get { return this.Sum(c => c.CoreCount); }
        }

        public int TotalLoadPercentage
        {
            get { return this.Sum(c => c.LoadPercentage) / this.TotalCpu; }
        }
    }
}
