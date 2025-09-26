using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktichna3_3_
{
    public class CardOplata : IOplata
    {
        private string cardN;
        private string cardC;
        public CardOplata(string cardN, string cardC)
        {
            this.cardN = cardN;
            this.cardC = cardC;
        }
        public void Opl(decimal am)
        {
            MessageBox.Show($"Оплата {am:C} карткою \nНомер картки: {cardN}\nКод карти: {cardC}");
        }
    }
}
