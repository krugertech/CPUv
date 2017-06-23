using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simplified.Environment;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {            
            CpuCollection cpus = Simplified.Environment.CPUv.GetCPUs();

            Console.WriteLine("Total CPUs: " + cpus.TotalCpu);
            Console.WriteLine("Total Cores: " + cpus.TotalCores);
            Console.WriteLine("Total Logical Cores: " + cpus.TotalLogicalCores);

            Console.WriteLine();
            foreach (var cpu in cpus)
            {
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine($"CPU Name: {cpu.Name}");
                Console.WriteLine($"Cores per CPU: {cpu.CoreCount}");
                Console.WriteLine($"Threads per CPU: {cpu.LogicalCoreCount}");
                Console.WriteLine($"Load: {cpu.LoadPercentage}%");
                Console.WriteLine($"Clock Speed: {cpu.CurrentClockSpeed}Mhz");
            }

            Console.ReadLine();
        }
    }
}
