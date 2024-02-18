
namespace Accounting_App
{
    partial class New_trans_form
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
            this.CustomersGPbox = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nametxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Rbreceive = new System.Windows.Forms.RadioButton();
            this.RbPay = new System.Windows.Forms.RadioButton();
            this.ValueBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Discriptiontxtbox = new System.Windows.Forms.TextBox();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.CustomersGPbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersGPbox
            // 
            this.CustomersGPbox.Controls.Add(this.dataGridView);
            this.CustomersGPbox.Controls.Add(this.FilterTextBox);
            this.CustomersGPbox.Location = new System.Drawing.Point(12, 12);
            this.CustomersGPbox.Name = "CustomersGPbox";
            this.CustomersGPbox.Size = new System.Drawing.Size(182, 232);
            this.CustomersGPbox.TabIndex = 0;
            this.CustomersGPbox.TabStop = false;
            this.CustomersGPbox.Text = "اشخاص";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Full_name});
            this.dataGridView.Location = new System.Drawing.Point(6, 47);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(170, 179);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // Full_name
            // 
            this.Full_name.DataPropertyName = "Customer_fullname";
            this.Full_name.HeaderText = "نام شخص : ";
            this.Full_name.Name = "Full_name";
            this.Full_name.ReadOnly = true;
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(6, 20);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(170, 21);
            this.FilterTextBox.TabIndex = 0;
            this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "طرف حساب : ";
            // 
            // Nametxtbox
            // 
            this.Nametxtbox.Location = new System.Drawing.Point(251, 32);
            this.Nametxtbox.Name = "Nametxtbox";
            this.Nametxtbox.ReadOnly = true;
            this.Nametxtbox.Size = new System.Drawing.Size(131, 21);
            this.Nametxtbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "نوع تراکنش : ";
            // 
            // Rbreceive
            // 
            this.Rbreceive.AutoSize = true;
            this.Rbreceive.Location = new System.Drawing.Point(337, 65);
            this.Rbreceive.Name = "Rbreceive";
            this.Rbreceive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Rbreceive.Size = new System.Drawing.Size(45, 17);
            this.Rbreceive.TabIndex = 4;
            this.Rbreceive.TabStop = true;
            this.Rbreceive.Text = "واریز";
            this.Rbreceive.UseVisualStyleBackColor = true;
            // 
            // RbPay
            // 
            this.RbPay.AutoSize = true;
            this.RbPay.Location = new System.Drawing.Point(251, 65);
            this.RbPay.Name = "RbPay";
            this.RbPay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RbPay.Size = new System.Drawing.Size(58, 17);
            this.RbPay.TabIndex = 5;
            this.RbPay.TabStop = true;
            this.RbPay.Text = "پرداخت";
            this.RbPay.UseVisualStyleBackColor = true;
            // 
            // ValueBox
            // 
            this.ValueBox.Location = new System.Drawing.Point(251, 101);
            this.ValueBox.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(131, 21);
            this.ValueBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "مقدار : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "توضیحات : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Discriptiontxtbox
            // 
            this.Discriptiontxtbox.Location = new System.Drawing.Point(251, 133);
            this.Discriptiontxtbox.Multiline = true;
            this.Discriptiontxtbox.Name = "Discriptiontxtbox";
            this.Discriptiontxtbox.Size = new System.Drawing.Size(131, 82);
            this.Discriptiontxtbox.TabIndex = 9;
            // 
            // Submitbtn
            // 
            this.Submitbtn.Location = new System.Drawing.Point(251, 221);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(131, 23);
            this.Submitbtn.TabIndex = 10;
            this.Submitbtn.Text = "ثبت ";
            this.Submitbtn.UseVisualStyleBackColor = true;
            this.Submitbtn.Click += new System.EventHandler(this.Submitbtn_Click);
            // 
            // New_trans_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 249);
            this.Controls.Add(this.Submitbtn);
            this.Controls.Add(this.Discriptiontxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.RbPay);
            this.Controls.Add(this.Rbreceive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nametxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomersGPbox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "New_trans_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تراکنش جدید";
            this.Load += new System.EventHandler(this.New_trans_form_Load);
            this.CustomersGPbox.ResumeLayout(false);
            this.CustomersGPbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CustomersGPbox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nametxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Rbreceive;
        private System.Windows.Forms.RadioButton RbPay;
        private System.Windows.Forms.NumericUpDown ValueBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Discriptiontxtbox;
        private System.Windows.Forms.Button Submitbtn;
    }
}