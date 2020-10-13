namespace P3Code
{
    partial class FormProjSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.formMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.projectBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.iProjectRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.projectBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.iProjectRepositoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fakeProjectRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iAppUserRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fakeAppUserRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.fakeAppUserRepositoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.formMainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iProjectRepositoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iProjectRepositoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeProjectRepositoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iAppUserRepositoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeAppUserRepositoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formLoginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeAppUserRepositoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Big Expensive Project1",
            "Big Expensive Project2",
            "Big Expensive Project3"});
            this.listBox1.Location = new System.Drawing.Point(50, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(406, 238);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // formMainBindingSource
            // 
            this.formMainBindingSource.DataSource = typeof(P3Code.FormMain);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Select Project";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // projectBindingSource2
            // 
            this.projectBindingSource2.DataSource = typeof(P3Code.Project);
            // 
            // iProjectRepositoryBindingSource
            // 
            this.iProjectRepositoryBindingSource.DataSource = typeof(P3Code.FakeProjectRepository);
            // 
            // projectBindingSource1
            // 
            this.projectBindingSource1.DataSource = typeof(P3Code.Project);
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(P3Code.Project);
            // 
            // projectBindingSource3
            // 
            this.projectBindingSource3.DataSource = typeof(P3Code.Project);
            // 
            // projectBindingSource4
            // 
            this.projectBindingSource4.DataSource = typeof(P3Code.Project);
            // 
            // iProjectRepositoryBindingSource1
            // 
            this.iProjectRepositoryBindingSource1.DataSource = typeof(P3Code.IProjectRepository);
            // 
            // fakeProjectRepositoryBindingSource
            // 
            this.fakeProjectRepositoryBindingSource.DataSource = typeof(P3Code.FakeProjectRepository);
            // 
            // appUserBindingSource
            // 
            this.appUserBindingSource.DataSource = typeof(P3Code.AppUser);
            // 
            // iAppUserRepositoryBindingSource
            // 
            this.iAppUserRepositoryBindingSource.DataSource = typeof(P3Code.IAppUserRepository);
            // 
            // fakeAppUserRepositoryBindingSource
            // 
            this.fakeAppUserRepositoryBindingSource.DataSource = typeof(P3Code.FakeAppUserRepository);
            // 
            // formLoginBindingSource
            // 
            this.formLoginBindingSource.DataSource = typeof(P3Code.FormLogin);
            // 
            // projectBindingSource5
            // 
            this.projectBindingSource5.DataSource = typeof(P3Code.Project);
            // 
            // fakeAppUserRepositoryBindingSource1
            // 
            this.fakeAppUserRepositoryBindingSource1.DataSource = typeof(P3Code.FakeAppUserRepository);
            // 
            // FormProjSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "FormProjSelect";
            this.Text = "Select Project";
            this.Load += new System.EventHandler(this.FormProjSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formMainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iProjectRepositoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iProjectRepositoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeProjectRepositoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iAppUserRepositoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeAppUserRepositoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formLoginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeAppUserRepositoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.BindingSource projectBindingSource1;
        private System.Windows.Forms.BindingSource iProjectRepositoryBindingSource;
        private System.Windows.Forms.BindingSource projectBindingSource2;
        private System.Windows.Forms.BindingSource projectBindingSource3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource projectBindingSource4;
        private System.Windows.Forms.BindingSource iProjectRepositoryBindingSource1;
        private System.Windows.Forms.BindingSource fakeProjectRepositoryBindingSource;
        private System.Windows.Forms.BindingSource appUserBindingSource;
        private System.Windows.Forms.BindingSource iAppUserRepositoryBindingSource;
        private System.Windows.Forms.BindingSource fakeAppUserRepositoryBindingSource;
        private System.Windows.Forms.BindingSource formLoginBindingSource;
        private System.Windows.Forms.BindingSource projectBindingSource5;
        private System.Windows.Forms.BindingSource formMainBindingSource;
        private System.Windows.Forms.BindingSource fakeAppUserRepositoryBindingSource1;
    }
}