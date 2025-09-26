using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktichna3_1_
{
    public class Director
    {
        private IComp bcomp;
        public Director(IComp comp)
        {
            bcomp = comp;
        }
        public void Construct()
        {
            bcomp.BuildCPU();
            bcomp.BuildGPU();
            bcomp.BuildRAM();
        }
    }
}
