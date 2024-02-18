
namespace Accounting_App
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Refreshbtn = new System.Windows.Forms.ToolStripButton();
            this.editbtn = new System.Windows.Forms.ToolStripButton();
            this.delbtn = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.EndDateBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StartDateBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvReport = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarafhesab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Refreshbtn,
            this.editbtn,
            this.delbtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Refreshbtn.Image = ((System.Drawing.Image)(resources.GetObject("Refreshbtn.Image")));
            this.Refreshbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(60, 22);
            this.Refreshbtn.Text = "بروزرسانی";
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editbtn.Image = ((System.Drawing.Image)(resources.GetObject("editbtn.Image")));
            this.editbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(47, 22);
            this.editbtn.Text = "ویرایش";
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.delbtn.Image = ((System.Drawing.Image)(resources.GetObject("delbtn.Image")));
            this.delbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(36, 22);
            this.delbtn.Text = "حذف";
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchbtn);
            this.groupBox1.Controls.Add(this.EndDateBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.StartDateBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(43, 33);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 7;
            this.searchbtn.Text = "جستجو";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // EndDateBox
            // 
            this.EndDateBox.Location = new System.Drawing.Point(200, 35);
            this.EndDateBox.Mask = "0000/00/00";
            this.EndDateBox.Name = "EndDateBox";
            this.EndDateBox.Size = new System.Drawing.Size(100, 21);
            this.EndDateBox.TabIndex = 6;
            this.EndDateBox.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "تا تاریخ : ";
            // 
            // StartDateBox
            // 
            this.StartDateBox.Location = new System.Drawing.Point(385, 35);
            this.StartDateBox.Mask = "0000/00/00";
            this.StartDateBox.Name = "StartDateBox";
            this.StartDateBox.Size = new System.Drawing.Size(100, 21);
            this.StartDateBox.TabIndex = 4;
            this.StartDateBox.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "از تاریخ : ";
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(570, 35);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 1;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(697, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "طرف حساب : ";
            // 
            // DgvReport
            // 
            this.DgvReport.AllowUserToAddRows = false;
            this.DgvReport.AllowUserToDeleteRows = false;
            this.DgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.customer_id,
            this.tarafhesab,
            this.value,
            this.discription,
            this.Date});
            this.DgvReport.Location = new System.Drawing.Point(12, 120);
            this.DgvReport.Name = "DgvReport";
            this.DgvReport.ReadOnly = true;
            this.DgvReport.Size = new System.Drawing.Size(776, 252);
            this.DgvReport.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "ایدی اصلی";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // customer_id
            // 
            this.customer_id.HeaderText = "ایدی";
            this.customer_id.Name = "customer_id";
            this.customer_id.ReadOnly = true;
            this.customer_id.Visible = false;
            // 
            // tarafhesab
            // 
            this.tarafhesab.HeaderText = "طرف حساب";
            this.tarafhesab.Name = "tarafhesab";
            this.tarafhesab.ReadOnly = true;
            // 
            // value
            // 
            this.value.HeaderText = "مبلغ";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            // 
            // discription
            // 
            this.discription.HeaderText = "توضیحات";
            this.discription.Name = "discription";
            this.discription.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "تاریخ";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 381);
            this.Controls.Add(this.DgvReport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Refreshbtn;
        private System.Windows.Forms.ToolStripButton editbtn;
        private System.Windows.Forms.ToolStripButton delbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvReport;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.MaskedTextBox EndDateBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox StartDateBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarafhesab;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn discription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}