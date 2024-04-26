using QL_Cafe.GUI;

namespace QL_Cafe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMain fmain = new fMain();
            fmain.Show();
        }
    }
}
