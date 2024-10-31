
namespace SolutionCreator
{
    partial class TemplateFileGenerator
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
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.txtNameSpace = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.chkSaveDirectToProject = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtFolderName
            // 
            this.txtFolderName.Location = new System.Drawing.Point(172, 59);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(168, 20);
            this.txtFolderName.TabIndex = 0;
            this.txtFolderName.Text = "Project1";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(172, 106);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(168, 20);
            this.txtTableName.TabIndex = 1;
            this.txtTableName.Text = "User";
            // 
            // txtNameSpace
            // 
            this.txtNameSpace.Location = new System.Drawing.Point(172, 153);
            this.txtNameSpace.Name = "txtNameSpace";
            this.txtNameSpace.Size = new System.Drawing.Size(168, 20);
            this.txtNameSpace.TabIndex = 2;
            this.txtNameSpace.Text = "ProjectName";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(265, 233);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // chkSaveDirectToProject
            // 
            this.chkSaveDirectToProject.AutoSize = true;
            this.chkSaveDirectToProject.Location = new System.Drawing.Point(191, 197);
            this.chkSaveDirectToProject.Name = "chkSaveDirectToProject";
            this.chkSaveDirectToProject.Size = new System.Drawing.Size(149, 17);
            this.chkSaveDirectToProject.TabIndex = 4;
            this.chkSaveDirectToProject.Text = "Save Direct Inside Project";
            this.chkSaveDirectToProject.UseVisualStyleBackColor = true;
            // 
            // TemplateFileGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkSaveDirectToProject);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtNameSpace);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.txtFolderName);
            this.Name = "TemplateFileGenerator";
            this.Text = "TemplateFileGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.TextBox txtNameSpace;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox chkSaveDirectToProject;
    }
}