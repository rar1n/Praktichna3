using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktichna3_2_
{
    public class OVal
    {
        public string GetK(string vp)
        {
            if (vp == "USD_EUR") return "0,85";
            if (vp == "EUR_USD") return "1,18";
            if (vp == "USD_UAH") return "41,3";
            if (vp == "UAH_USD") return "0,024";
            if (vp == "EUR_UAH") return "48,2";
            if (vp == "UAH_EUR") return "0,02";
            if (vp == "UAH_UAH") return "1";
            if (vp == "USD_USD") return "1";
            if (vp == "EUR_EUR") return "1";
            return "1";
        }
    }
}
