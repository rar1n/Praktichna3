using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktichna3_1_
{
    public interface IComp
    {
        void BuildCPU();
        void BuildRAM();
        void BuildGPU();
        Computer GetComputer();
    }
}
