namespace praktichna3_3_
{
    public partial class Form1 : Form
    {
        private OplataC OplataC;
        public Form1()
        {
            InitializeComponent();
            OplataC = new OplataC();
            cbOpl.Items.Add("��������� �����");
            cbOpl.Items.Add("���������� �������");
            cbOpl.Items.Add("������������");
            cbOpl.SelectedIndex = 0;
            UpdVsbF();
        }

        private void cbOpl_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdVsbF();
        }
        private void UpdVsbF()
        {
            lCardN.Visible = false;
            tbCardN.Visible = false;
            lCardC.Visible = false;
            tbCardC.Visible = false;

            lBNo.Visible = false;
            tbBNo.Visible = false;
            lBNa.Visible = false;
            tbBNa.Visible = false;

            lCN.Visible = false;
            tbCN.Visible = false;

            string s = cbOpl.SelectedItem.ToString();
            switch (s)
            {
                case "��������� �����":
                    lCardN.Visible = true;
                    tbCardN.Visible = true;
                    lCardC.Visible = true;
                    tbCardC.Visible = true;
                    break;
                case "���������� �������":
                    lBNo.Visible = true;
                    tbBNo.Visible = true;
                    lBNa.Visible = true;
                    tbBNa.Visible = true;
                    break;
                case "������������":
                    lCN.Visible = true;
                    tbCN.Visible = true;
                    break;
            }
        }

        private void btnOpl_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(tbAm.Text, out decimal am) || am <= 0)
            {
                MessageBox.Show("������ �������� ����");
                return;
            }
            string s = cbOpl.SelectedItem.ToString();
            switch (s)
            {
                case "��������� �����":
                    string cardN = tbCardN.Text.Trim();
                    string cardC = tbCardC.Text.Trim();
                    if (string.IsNullOrEmpty(cardN) || string.IsNullOrEmpty(cardC))
                    {
                        MessageBox.Show("������ ����� �� ��� ������");
                        return;
                    }
                    OplataC.SOpl(new CardOplata(cardN, cardC));
                    break;
                case "���������� �������":
                    string acN = tbBNo.Text.Trim();
                    string bN = tbBNa.Text.Trim();
                    if (string.IsNullOrEmpty(acN) || string.IsNullOrEmpty(bN))
                    {
                        MessageBox.Show("������ ����� ������� �� ����� �����");
                        return;
                    }
                    OplataC.SOpl(new BOplata(acN, bN));
                    break;
                case "������������":
                    string w = tbCN.Text.Trim();
                    if (string.IsNullOrEmpty(w))
                    {
                        MessageBox.Show("������ ����� �������");
                        return;
                    }
                    OplataC.SOpl(new COplata(w));
                    break;
            }
            OplataC.OplAm(am);
        }
    }
}
