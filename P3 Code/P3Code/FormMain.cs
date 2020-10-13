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
    public partial class FormMain : Form
    {
        private string selectedProj;
        public FormMain(string Proj)
        {
            InitializeComponent();
            selectedProj = Proj;
            setText();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Text = "Main - " + FormProjSelect.selectedName;
            CenterToScreen();
            //this.Hide();
            //AppUser person = new AppUser();
            //FormLogin login_form = new FormLogin();
            //while(!person.IsAuthenticated && login_form.ShowDialog() == DialogResult.OK)
            //{
            //    person.IsAuthenticated = login_form.Authenticated;
            //    if (!person.IsAuthenticated)
            //    {
            //        login_form.ShowDialog();
            //    }
                
            //}
            //this.Show();
        }

        private void createProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modifyProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void removeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProjSelect formProjSelect = new FormProjSelect();
            while(formProjSelect.DialogResult != DialogResult.OK)
            {
                this.Hide();
                formProjSelect.ShowDialog();
            }
            selectedProj = formProjSelect.selectedName;
            setText();
            this.Show();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void countByAssigneeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listByAssigneeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void countByArtifactToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listByArtifactToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void countByDateRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listByDateRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trendByDateRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void setText()
        {
            this.Text = "Main - " + selectedProj;
        }
    }
}
