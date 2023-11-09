namespace MyFirstForm
{
    public partial class MyNewForm : Form
    {
        public MyNewForm()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            /*if (BtnOk_Click  true ); 
            {
                txtFrase.Visible = true;
            }*/
            txtFrase.Text = "Jhow Zinho Negro";

        }

        private void TxtFrase_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFrase.Text = "";
        }
    }
}