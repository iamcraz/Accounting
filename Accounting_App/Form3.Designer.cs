
namespace Accounting_App
{
    partial class AddOrEditform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrEditform));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.mobiletxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picbtn = new System.Windows.Forms.Button();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addresstxt);
            this.groupBox1.Controls.Add(this.emailtxt);
            this.groupBox1.Controls.Add(this.mobiletxt);
            this.groupBox1.Controls.Add(this.nametxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(257, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات فرد";
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(0, 230);
            this.addresstxt.Multiline = true;
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(259, 51);
            this.addresstxt.TabIndex = 7;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(0, 169);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(259, 21);
            this.emailtxt.TabIndex = 6;
            // 
            // mobiletxt
            // 
            this.mobiletxt.Location = new System.Drawing.Point(0, 109);
            this.mobiletxt.Name = "mobiletxt";
            this.mobiletxt.Size = new System.Drawing.Size(259, 21);
            this.mobiletxt.TabIndex = 5;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(0, 44);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(259, 21);
            this.nametxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "آدرس : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ایمیل : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "تلفن همراه : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کامل : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picbtn);
            this.groupBox2.Controls.Add(this.picbox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 287);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تصویر فرد";
            // 
            // picbtn
            // 
            this.picbtn.Location = new System.Drawing.Point(6, 249);
            this.picbtn.Name = "picbtn";
            this.picbtn.Size = new System.Drawing.Size(227, 32);
            this.picbtn.TabIndex = 1;
            this.picbtn.Text = "انتخاب تصویر";
            this.picbtn.UseVisualStyleBackColor = true;
            this.picbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // picbox
            // 
            this.picbox.Image = ((System.Drawing.Image)(resources.GetObject("picbox.Image")));
            this.picbox.Location = new System.Drawing.Point(6, 17);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(227, 226);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox.TabIndex = 0;
            this.picbox.TabStop = false;
            // 
            // Submitbtn
            // 
            this.Submitbtn.Location = new System.Drawing.Point(441, 305);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(75, 23);
            this.Submitbtn.TabIndex = 2;
            this.Submitbtn.Text = "ثبت";
            this.Submitbtn.UseVisualStyleBackColor = true;
            this.Submitbtn.Click += new System.EventHandler(this.Submitbtn_Click);
            // 
            // AddOrEditform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 336);
            this.Controls.Add(this.Submitbtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddOrEditform";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرم افزودن و ویرایش";
            this.Load += new System.EventHandler(this.AddOrEditform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox mobiletxt;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Button picbtn;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Button Submitbtn;
    }
}