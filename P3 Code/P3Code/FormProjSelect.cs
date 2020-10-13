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
    public partial class FormProjSelect : Form
    {
        public FakeProjectRepository newRepo = new FakeProjectRepository();
        public Project SelectedProject;
        public List<Project> projects = new List<Project>();
        public bool isSelected = false;
        public string selectedName { get; set; }
        public string Id { get; set; }

        public FormProjSelect()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void FormProjSelect_Load(object sender, EventArgs e)
        {
            projects = newRepo.GetAll();
            foreach (Project project in projects)
            {
                listBox1.Items.Add(project.Id.ToString() + " - " + project.Name);
            }
            listBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string SelectedProject = listBox1.SelectedItem.ToString();
            //label1.Text = SelectedProject;
            SelectedProject = projects[listBox1.SelectedIndex];
            selectedName = SelectedProject.Name;
            Id = SelectedProject.Id.ToString();
            isSelected = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
