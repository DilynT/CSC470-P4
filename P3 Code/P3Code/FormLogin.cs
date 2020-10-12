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

        public bool UserAuthed { get; private set; }
        public FormLogin()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            FakeAppUserRepository repository = new FakeAppUserRepository();
            string username = UserNametextBox.Text;
            string password = PasswordtextBox.Text;
            Authenticated = repository.Login(username, password);
            if (Authenticated)
            {
                repository.setAuthentication(username, Authenticated);
                this.DialogResult = DialogResult.OK;
                UserAuthed = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect User Name or Password", "Attention", MessageBoxButtons.OK);
                PasswordtextBox.Text = "";
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
