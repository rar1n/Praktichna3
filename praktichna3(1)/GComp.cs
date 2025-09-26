using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktichna3_1_
{
    public class GComp : IComp
    {
        private Computer comp = new Computer();
        public void BuildCPU()
        {
            comp.CPU = "Intel Core i9-13900K";
        }
        public void BuildGPU()
        {
            comp.GPU = "NVIDIA GeForce RTX 5090";
        }
        public void BuildRAM()
        {
            comp.RAM = "64GB DDR5";
        }
        public Computer GetComputer()
        {
            return comp;
        }
    }
}
