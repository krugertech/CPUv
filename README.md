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

# License
Copyright (c) 2017 Llewellyn Kruger

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
