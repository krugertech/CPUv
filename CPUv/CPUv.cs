using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplified.Environment
{
    public class CPUv
    {
        public static CpuCollection GetCPUs()
        {
            CpuCollection cpus = WmiController.GetCpus();
            return cpus;
        }
    }
}
