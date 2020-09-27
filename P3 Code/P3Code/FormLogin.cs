using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3Code
{
    public partial class FormLogin : Form
    {
        public bool Authenticated { get; set; }
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FakeAppUserRepository repository = new FakeAppUserRepository();
            string username = UserNametextBox.Text;
            string password = PasswordtextBox.Text;
            Authenticated = repository.Login(username, password);
            if (Authenticated)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
