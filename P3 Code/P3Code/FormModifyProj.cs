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
    public partial class FormModifyProj : Form
    {
        public FakeProjectRepository projRepo;
        public int id_to_modify;
        public string project_text;
        public FormModifyProj()
        {
            InitializeComponent();
            CenterToScreen();
            projRepo = new FakeProjectRepository();
        }

        private void FormModifyProj_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            textBoxModify.Text = project_text;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            project_text = textBoxModify.Text.Trim();
            string ModResult = projRepo.Modify(id_to_modify, project_text);
            if (ModResult.Equals(FakeProjectRepository.NO_ERROR))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(this, ModResult, "Modify Project Failed", MessageBoxButtons.OK);
            }
        }
    }
}
