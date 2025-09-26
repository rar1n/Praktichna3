using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktichna3_3_
{
    public class BOplata : IOplata
    {
        private string acN;
        private string bN;
        public BOplata(string acN, string bN)
        {
            this.acN = acN;
            this.bN = bN;
        }
        public void Opl(decimal am)
        {
            MessageBox.Show($"Оплата {am:C} банківським переказом \nРахунок: {acN}\nБанк: {bN}");
        }
    }
}
