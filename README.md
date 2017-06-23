# CPUv
A great little library for querying all relevant CPU information in .Net

• Supports multi processor servers with 64+ cores.

• Provides CPU, Core and Logical Core counts accurately.

• Useful info such as CPU Clock Speed and Percentage Load.

• Very simple to use object collection model.

# Demo

```cs
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
```

![alt text](https://raw.githubusercontent.com/krugertech/CPUv/master/CPUvDemo.png)
