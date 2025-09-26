using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktichna3_1_
{
    public class Computer
    {
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string RAM { get; set; }
        public override string ToString()
        {
            return $"CPU: {CPU}, \r\nGPU: {GPU}, \r\nRAM: {RAM}";
        }
    }
}
