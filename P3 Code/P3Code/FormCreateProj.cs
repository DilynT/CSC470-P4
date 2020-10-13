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
    public partial class FormCreateProj : Form
    {
        public FakeProjectRepository projRepo;
        public string newProject;
        public FormCreateProj()
        {
            InitializeComponent();
            CenterToScreen();
            projRepo = new FakeProjectRepository();
        }

        private void addProject_Click(object sender, EventArgs e)
        {
            newProject = projName.Text.Trim();
            string addResult = projRepo.Add(newProject);
            if(addResult.Equals(FakeProjectRepository.NO_ERROR))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(this, addResult, "Create Project Failed", MessageBoxButtons.OK);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
