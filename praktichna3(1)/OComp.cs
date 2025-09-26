using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktichna3_1_
{
    public class OComp : IComp
    {
        private Computer comp = new Computer();
        public void BuildCPU()
        {
            comp.CPU = "AMD Ryzen 5 5600";
        }
        public void BuildGPU()
        {
            comp.GPU = "NVIDIA GeForce GTX 750";
        }
        public void BuildRAM()
        {
            comp.RAM = "8GB DDR4";
        }
        public Computer GetComputer()
        {
            return comp;
        }
    }
}
