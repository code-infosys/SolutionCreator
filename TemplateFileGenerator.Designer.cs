
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDeleteJsonPath = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFolderName
            // 
            this.txtFolderName.Location = new System.Drawing.Point(96, 45);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(168, 20);
            this.txtFolderName.TabIndex = 0;
            this.txtFolderName.Text = "Project1";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(96, 92);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(168, 20);
            this.txtTableName.TabIndex = 1;
            this.txtTableName.Text = "User";
            // 
            // txtNameSpace
            // 
            this.txtNameSpace.Location = new System.Drawing.Point(96, 139);
            this.txtNameSpace.Name = "txtNameSpace";
            this.txtNameSpace.Size = new System.Drawing.Size(168, 20);
            this.txtNameSpace.TabIndex = 2;
            this.txtNameSpace.Text = "ProjectName";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(189, 219);
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
            this.chkSaveDirectToProject.Location = new System.Drawing.Point(115, 183);
            this.chkSaveDirectToProject.Name = "chkSaveDirectToProject";
            this.chkSaveDirectToProject.Size = new System.Drawing.Size(149, 17);
            this.chkSaveDirectToProject.TabIndex = 4;
            this.chkSaveDirectToProject.Text = "Save Direct Inside Project";
            this.chkSaveDirectToProject.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtDeleteJsonPath);
            this.groupBox1.Location = new System.Drawing.Point(503, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 142);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Log";
            // 
            // txtDeleteJsonPath
            // 
            this.txtDeleteJsonPath.Location = new System.Drawing.Point(22, 51);
            this.txtDeleteJsonPath.Name = "txtDeleteJsonPath";
            this.txtDeleteJsonPath.Size = new System.Drawing.Size(242, 20);
            this.txtDeleteJsonPath.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(189, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Delete Path";
            // 
            // TemplateFileGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkSaveDirectToProject);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtNameSpace);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.txtFolderName);
            this.Name = "TemplateFileGenerator";
            this.Text = "TemplateFileGenerator";
            this.Load += new System.EventHandler(this.TemplateFileGenerator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.TextBox txtNameSpace;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox chkSaveDirectToProject;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDeleteJsonPath;
    }
}