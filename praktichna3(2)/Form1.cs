namespace praktichna3_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(tbS.Text, out decimal am))
            {
                MessageBox.Show("¬вед≥ть правильну суму");
                return;
            }
            string fVal = cbF.Text.ToUpper();
            string tVal = cbT.Text.ToUpper();

            OVal oval = new OVal();
            IValConv valconv = new ValAdap(oval);

            decimal r = valconv.Conv(am, fVal, tVal);
            tbR.Text = $"{am} {fVal} = {r:F2} {tVal}";
        }
    }
}
