using System.Windows.Forms;

namespace Addressbook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_save_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string email = txt_email.Text;
            string phone = txt_phonenumber.Text;
            MessageBox.Show($"Name: {name}\nEmail: {email}\nPhone: {phone}", "Saved Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
