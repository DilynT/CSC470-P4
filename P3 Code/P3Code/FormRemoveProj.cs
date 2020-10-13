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
    public partial class FormRemoveProj : Form
    {
        public FakeProjectRepository projRepo;
        public FakePreferencceRepository prefRepo;
        public int id_to_modify;
        public string project_text;
        public FormRemoveProj()
        {
            InitializeComponent();
            CenterToScreen();
            projRepo = new FakeProjectRepository();
            prefRepo = new FakePreferencceRepository();
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to delete the project?";
            const string caption = "Project Deleting";
            var result = MessageBox.Show(message, caption,
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string RemResult = projRepo.Remove(id_to_modify);
                if (RemResult.Equals(FakeProjectRepository.NO_ERROR))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, RemResult, "Delete Project Failed", MessageBoxButtons.OK);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormRemoveProj_Load(object sender, EventArgs e)
        {
            lblProject.Text = project_text;
        }
    }
}
