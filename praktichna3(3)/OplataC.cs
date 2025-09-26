using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktichna3_3_
{
    public class OplataC
    {
        private IOplata _oplata;
        public void SOpl(IOplata oplata)
        {
            _oplata = oplata;
        }
        public void OplAm(decimal am)
        {
            if (_oplata == null)
            {
                MessageBox.Show("Виберіть спосіб оплати");
                return;
            }
            _oplata.Opl(am);
        }
    }
}
