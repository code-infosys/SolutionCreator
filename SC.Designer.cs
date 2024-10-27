namespace SolutionCreator
{
    partial class SC
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProcess = new System.Windows.Forms.Label();
            this.txtNewSolutionName = new System.Windows.Forms.TextBox();
            this.txtSourceSolutionName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.txtDestinationUrl = new System.Windows.Forms.TextBox();
            this.txtSourceUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProcess);
            this.groupBox1.Controls.Add(this.txtNewSolutionName);
            this.groupBox1.Controls.Add(this.txtSourceSolutionName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.ProgressBar);
            this.groupBox1.Controls.Add(this.txtDestinationUrl);
            this.groupBox1.Controls.Add(this.txtSourceUrl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(50, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Location = new System.Drawing.Point(210, 221);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(0, 13);
            this.lblProcess.TabIndex = 10;
            // 
            // txtNewSolutionName
            // 
            this.txtNewSolutionName.Location = new System.Drawing.Point(206, 143);
            this.txtNewSolutionName.Name = "txtNewSolutionName";
            this.txtNewSolutionName.Size = new System.Drawing.Size(215, 20);
            this.txtNewSolutionName.TabIndex = 9;
            // 
            // txtSourceSolutionName
            // 
            this.txtSourceSolutionName.Location = new System.Drawing.Point(206, 107);
            this.txtSourceSolutionName.Name = "txtSourceSolutionName";
            this.txtSourceSolutionName.Size = new System.Drawing.Size(215, 20);
            this.txtSourceSolutionName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "New Solution Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Source Solution Name:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(206, 183);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(85, 23);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(206, 246);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(424, 10);
            this.ProgressBar.TabIndex = 4;
            // 
            // txtDestinationUrl
            // 
            this.txtDestinationUrl.Location = new System.Drawing.Point(206, 69);
            this.txtDestinationUrl.Name = "txtDestinationUrl";
            this.txtDestinationUrl.Size = new System.Drawing.Size(424, 20);
            this.txtDestinationUrl.TabIndex = 3;
            // 
            // txtSourceUrl
            // 
            this.txtSourceUrl.Location = new System.Drawing.Point(206, 34);
            this.txtSourceUrl.Name = "txtSourceUrl";
            this.txtSourceUrl.Size = new System.Drawing.Size(424, 20);
            this.txtSourceUrl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination Directory Url:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Solution Directory Url:";
            // 
            // SC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 379);
            this.Controls.Add(this.groupBox1);
            this.Name = "SC";
            this.Text = "Stark Solution Creator";
            this.Load += new System.EventHandler(this.SC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.TextBox txtDestinationUrl;
        private System.Windows.Forms.TextBox txtSourceUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewSolutionName;
        private System.Windows.Forms.TextBox txtSourceSolutionName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProcess;
    }
}