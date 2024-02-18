
namespace Accounting_App
{
    partial class frmcustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcustomers));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addbtn = new System.Windows.Forms.ToolStripButton();
            this.editbtn = new System.Windows.Forms.ToolStripButton();
            this.deletebtn = new System.Windows.Forms.ToolStripButton();
            this.refreshbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchtxtbox = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addbtn,
            this.editbtn,
            this.deletebtn,
            this.refreshbtn,
            this.toolStripLabel1,
            this.searchtxtbox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addbtn
            // 
            this.addbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addbtn.Image = ((System.Drawing.Image)(resources.GetObject("addbtn.Image")));
            this.addbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(70, 22);
            this.addbtn.Text = "شخص جدید";
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
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
            // deletebtn
            // 
            this.deletebtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deletebtn.Image = ((System.Drawing.Image)(resources.GetObject("deletebtn.Image")));
            this.deletebtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(72, 22);
            this.deletebtn.Text = "حذف شخص";
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshbtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshbtn.Image")));
            this.refreshbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(60, 22);
            this.refreshbtn.Text = "بروزرسانی";
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "جستجو : ";
            // 
            // searchtxtbox
            // 
            this.searchtxtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchtxtbox.Name = "searchtxtbox";
            this.searchtxtbox.Size = new System.Drawing.Size(100, 25);
            this.searchtxtbox.Click += new System.EventHandler(this.searchtxtbox_Click);
            this.searchtxtbox.TextChanged += new System.EventHandler(this.searchtxtbox_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_id,
            this.Customer_fullname,
            this.Customer_mobile,
            this.Customer_email,
            this.image});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 25);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(584, 336);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Customer_id
            // 
            this.Customer_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer_id.DataPropertyName = "Customer_id";
            this.Customer_id.HeaderText = "کد شخص";
            this.Customer_id.Name = "Customer_id";
            // 
            // Customer_fullname
            // 
            this.Customer_fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer_fullname.DataPropertyName = "Customer_fullname";
            this.Customer_fullname.HeaderText = "نام شخص";
            this.Customer_fullname.Name = "Customer_fullname";
            // 
            // Customer_mobile
            // 
            this.Customer_mobile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer_mobile.DataPropertyName = "Customer_mobile";
            this.Customer_mobile.HeaderText = "شماره موبایل";
            this.Customer_mobile.Name = "Customer_mobile";
            // 
            // Customer_email
            // 
            this.Customer_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer_email.DataPropertyName = "Customer_Email";
            this.Customer_email.HeaderText = "ایمیل";
            this.Customer_email.Name = "Customer_email";
            // 
            // image
            // 
            this.image.DataPropertyName = "Customer_image";
            this.image.HeaderText = "تصویر";
            this.image.Name = "image";
            this.image.Visible = false;
            // 
            // frmcustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmcustomers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرم اشخاص طرف حساب";
            this.Load += new System.EventHandler(this.frmcustomers_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addbtn;
        private System.Windows.Forms.ToolStripButton editbtn;
        private System.Windows.Forms.ToolStripButton deletebtn;
        private System.Windows.Forms.ToolStripButton refreshbtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox searchtxtbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn image;
    }
}