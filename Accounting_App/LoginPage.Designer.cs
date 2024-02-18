
namespace Accounting_App
{
    partial class LoginPage
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
            this.PassWordtxt = new System.Windows.Forms.TextBox();
            this.UserNametxt = new System.Windows.Forms.TextBox();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.Pass = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PassWordtxt);
            this.groupBox1.Controls.Add(this.UserNametxt);
            this.groupBox1.Controls.Add(this.Submitbtn);
            this.groupBox1.Controls.Add(this.Pass);
            this.groupBox1.Controls.Add(this.UserName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 208);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "صفحه ورود";
            // 
            // PassWordtxt
            // 
            this.PassWordtxt.Location = new System.Drawing.Point(34, 96);
            this.PassWordtxt.Name = "PassWordtxt";
            this.PassWordtxt.Size = new System.Drawing.Size(100, 20);
            this.PassWordtxt.TabIndex = 9;
            // 
            // UserNametxt
            // 
            this.UserNametxt.Location = new System.Drawing.Point(34, 56);
            this.UserNametxt.Name = "UserNametxt";
            this.UserNametxt.Size = new System.Drawing.Size(100, 20);
            this.UserNametxt.TabIndex = 8;
            // 
            // Submitbtn
            // 
            this.Submitbtn.Location = new System.Drawing.Point(34, 147);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(159, 23);
            this.Submitbtn.TabIndex = 7;
            this.Submitbtn.Text = "ورود";
            this.Submitbtn.UseVisualStyleBackColor = true;
            this.Submitbtn.Click += new System.EventHandler(this.Submitbtn_Click);
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Location = new System.Drawing.Point(140, 99);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(56, 13);
            this.Pass.TabIndex = 6;
            this.Pass.Text = "رمز عبور : ";
            this.Pass.Click += new System.EventHandler(this.Pass_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(148, 59);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(41, 13);
            this.UserName.TabIndex = 5;
            this.UserName.Text = "کاربر : ";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 232);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PassWordtxt;
        private System.Windows.Forms.TextBox UserNametxt;
        private System.Windows.Forms.Button Submitbtn;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Label UserName;
    }
}