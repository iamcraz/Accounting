using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Accounting_Datalayer;



namespace Accounting_App
{   
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage frm = new LoginPage();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                
            }
            else
            {
                Application.Exit();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncustomers_Click(object sender, EventArgs e)
        {
            frmcustomers frm_customers = new frmcustomers();
            frm_customers.ShowDialog();
        }

        private void newtransbtn_Click(object sender, EventArgs e)
        {
            New_trans_form frm = new New_trans_form();

            frm.ShowDialog();

        }

        private void ReceiveReportbtn_Click(object sender, EventArgs e)
        {
            ReportForm frm = new ReportForm();
            frm.type = 1;
            frm.ShowDialog();
        }

        private void PayReportbtn_Click(object sender, EventArgs e)
        {
            ReportForm frm = new ReportForm();
            frm.type = 2;
            frm.ShowDialog();
        }
    }
}
