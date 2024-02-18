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
using System.IO;

namespace Accounting_App
{
    public partial class frmcustomers : Form
    {
        public frmcustomers()
        {
            InitializeComponent();
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmcustomers_Load(object sender, EventArgs e)
        {
            bind_selectall();
            

        }

        private void bind_selectall()
        {
            using (Unitofwork db = new Unitofwork())
            {
                dataGridView.Columns[0].Visible = false;
                dataGridView.AutoGenerateColumns = false;
                dataGridView.DataSource = db.Customer_Repository.GetAllCustomers();
                searchtxtbox.Text = "";
                
            }
            
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            bind_selectall();
        }

        private void searchtxtbox_Click(object sender, EventArgs e)
        {

        }

        private void searchtxtbox_TextChanged(object sender, EventArgs e)
        {
            using (Unitofwork db = new Unitofwork())
            {
                dataGridView.AutoGenerateColumns = false;
                dataGridView.DataSource=db.Customer_Repository.SearchCustomer(searchtxtbox.Text);
                

                db.Customer_Repository.Save();
                
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            AddOrEditform frm = new AddOrEditform();
            frm.Customer_id = 0;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                bind_selectall();
            }
            else
            {
                MessageBox.Show("به مشکل برخوردیم !", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            //try
            //{
                

                int Customer_id = int.Parse(dataGridView.CurrentRow.Cells[0].Value.ToString());

                using (Unitofwork db = new Unitofwork())
                {
                    db.Customer_Repository.DeleteCustomer(Customer_id);
                }
                bind_selectall();
            //}
            /*catch
            {
                MessageBox.Show("عکس های مربوطه پاک نشد ", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
          
            
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddOrEditform frm = new AddOrEditform();
                frm.Customer_id = int.Parse(dataGridView.CurrentRow.Cells[0].Value.ToString());
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    bind_selectall();
                }
                else
                {
                    MessageBox.Show("به مشکل برخوردیم !", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("خطا", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
