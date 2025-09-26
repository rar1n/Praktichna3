using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktichna3_3_
{
    public class COplata : IOplata
    {
        private string wN;
        public COplata(string wN)
        {
            this.wN = wN;
        }
        public void Opl(decimal am)
        {
            MessageBox.Show($"Оплата {am:C} криптовалютою \nГаманець: {wN}");
        }
    }
}
