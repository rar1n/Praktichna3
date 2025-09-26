namespace praktichna3_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            IComp comp;
            if (cbC.SelectedItem.ToString() == "Ігровий комп'ютер")
            {
                comp = new GComp();
            }
            else
            {
                comp = new OComp();
            }
            Director director = new Director(comp);
            director.Construct();

            Computer computer = comp.GetComputer();
            tbR.Text = computer.ToString();
        }
    }
}
