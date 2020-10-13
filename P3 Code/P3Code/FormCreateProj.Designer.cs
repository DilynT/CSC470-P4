namespace P3Code
{
    partial class FormCreateProj
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
            this.addProject = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.projName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addProject
            // 
            this.addProject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addProject.Location = new System.Drawing.Point(211, 183);
            this.addProject.Name = "addProject";
            this.addProject.Size = new System.Drawing.Size(127, 42);
            this.addProject.TabIndex = 0;
            this.addProject.Text = "Add";
            this.addProject.UseVisualStyleBackColor = true;
            this.addProject.Click += new System.EventHandler(this.addProject_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.Location = new System.Drawing.Point(361, 183);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(127, 42);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // projName
            // 
            this.projName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.projName.Location = new System.Drawing.Point(134, 97);
            this.projName.Name = "projName";
            this.projName.Size = new System.Drawing.Size(318, 20);
            this.projName.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(52, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(76, 13);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Project Name";
            // 
            // FormCreateProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 271);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.projName);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addProject);
            this.Name = "FormCreateProj";
            this.Text = "Create Project";
            this.Load += new System.EventHandler(this.FormCreateProj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addProject;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox projName;
        private System.Windows.Forms.TextBox textBox1;
    }
}