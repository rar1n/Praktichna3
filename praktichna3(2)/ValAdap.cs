using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktichna3_2_
{
    public class ValAdap : IValConv
    {
        private OVal _oval;
        public ValAdap(OVal oval)
        {
            _oval = oval;
        }
        public decimal Conv(decimal am, string fVal, string tVal)
        {
            string vp = $"{fVal}_{tVal}";
            string kStr = _oval.GetK(vp);
            if (decimal.TryParse(kStr, out decimal k))
            {
                return am * k;
            }
            return am;
        }
    }
}
