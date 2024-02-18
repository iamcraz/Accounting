
namespace Accounting_App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btncustomers = new System.Windows.Forms.ToolStripButton();
            this.newtransbtn = new System.Windows.Forms.ToolStripButton();
            this.ReceiveReportbtn = new System.Windows.Forms.ToolStripButton();
            this.PayReportbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btncustomers,
            this.newtransbtn,
            this.ReceiveReportbtn,
            this.PayReportbtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(359, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btncustomers
            // 
            this.btncustomers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btncustomers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btncustomers.Image = ((System.Drawing.Image)(resources.GetObject("btncustomers.Image")));
            this.btncustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncustomers.Name = "btncustomers";
            this.btncustomers.Size = new System.Drawing.Size(71, 22);
            this.btncustomers.Text = "طرف حساب";
            this.btncustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btncustomers.Click += new System.EventHandler(this.btncustomers_Click);
            // 
            // newtransbtn
            // 
            this.newtransbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newtransbtn.Image = ((System.Drawing.Image)(resources.GetObject("newtransbtn.Image")));
            this.newtransbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newtransbtn.Name = "newtransbtn";
            this.newtransbtn.Size = new System.Drawing.Size(72, 22);
            this.newtransbtn.Text = "تراکنش جدید";
            this.newtransbtn.Click += new System.EventHandler(this.newtransbtn_Click);
            // 
            // ReceiveReportbtn
            // 
            this.ReceiveReportbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ReceiveReportbtn.Image = ((System.Drawing.Image)(resources.GetObject("ReceiveReportbtn.Image")));
            this.ReceiveReportbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReceiveReportbtn.Name = "ReceiveReportbtn";
            this.ReceiveReportbtn.Size = new System.Drawing.Size(91, 22);
            this.ReceiveReportbtn.Text = "گزارش واریزی ها";
            this.ReceiveReportbtn.Click += new System.EventHandler(this.ReceiveReportbtn_Click);
            // 
            // PayReportbtn
            // 
            this.PayReportbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PayReportbtn.Image = ((System.Drawing.Image)(resources.GetObject("PayReportbtn.Image")));
            this.PayReportbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PayReportbtn.Name = "PayReportbtn";
            this.PayReportbtn.Size = new System.Drawing.Size(97, 22);
            this.PayReportbtn.Text = "گزارش پرداختی ها";
            this.PayReportbtn.Click += new System.EventHandler(this.PayReportbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 44);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامه حسابداری";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btncustomers;
        private System.Windows.Forms.ToolStripButton newtransbtn;
        private System.Windows.Forms.ToolStripButton ReceiveReportbtn;
        private System.Windows.Forms.ToolStripButton PayReportbtn;
    }
}

