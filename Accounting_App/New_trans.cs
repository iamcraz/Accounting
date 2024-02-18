using Accounting_Datalayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_App
{
    public partial class New_trans_form : Form
    {
        public int accounting_id = 0;
        public int Customer_id = 0;
        public New_trans_form()
        {
            InitializeComponent();
            
        }

        public Accounting_ accounting;
       
        private void New_trans_form_Load(object sender, EventArgs e)
        {
            using (Unitofwork db = new Unitofwork())
            {
                dataGridView.AutoGenerateColumns = false;
                dataGridView.DataSource = db.Customer_Repository.getNames();

                if (accounting_id != 0)
                {
                    this.Text = "ویرایش تراکنش";
                    accounting= db.Accounting_Repository.GetById(accounting_id);
                    string customer_name = db.Customer_Repository.GetCustomerNameById(accounting.Customer_ID);
                    Nametxtbox.Text = customer_name;
                    
                    if (accounting.Type_ID == 1)
                    {
                        Rbreceive.Checked = true;
                    }
                    else
                    {
                        RbPay.Checked = true;
                    }

                    ValueBox.Value = accounting.Amount;
                    Discriptiontxtbox.Text = accounting.Discription;

                   
                }
                else
                {
                    this.Text = "تراکنش جدید";
                }

            }
            
            
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            using (Unitofwork db=new Unitofwork())
            {
                dataGridView.AutoGenerateColumns = false;
                dataGridView.DataSource = db.Customer_Repository.getNames(FilterTextBox.Text);
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                
                    Nametxtbox.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
                
                
            }
            catch
            {
                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            int customer_id;
            int type;
            int value = int.Parse(ValueBox.Value.ToString());
            using (Unitofwork db = new Unitofwork())
            {
                 customer_id = db.Customer_Repository.GetCustomerIdByName(Nametxtbox.Text);
            }
                if (Nametxtbox.Text != "" && value != 0)
                {
                    if (RbPay.Checked || Rbreceive.Checked)
                    {
                        if (RbPay.Checked)
                        {
                             type = 2;
                        }
                        else
                        {
                             type = 1;
                        }
                        
                        
                        using (Unitofwork db=new Unitofwork())
                        {
                        
                        
                            Accounting_ acc = new Accounting_()
                            {
                                Customer_ID = customer_id,
                                Type_ID = type,
                                Amount = value,
                                Discription = Discriptiontxtbox.Text,
                                Date_time = DateTime.Now,

                            };
                            if (accounting_id == 0)
                            {
    
                                db.Accounting_Repository.Insert(acc);
                                db.save();
                            
                            }
                            else
                            {
                                acc.ID = accounting_id;
                            


                                db.Accounting_Repository.Update(acc);
                                db.save();
                               
                            }
                            DialogResult = DialogResult.OK;
                        }
                        
                       

                    }
                    else
                    {
                        MessageBox.Show("یک گزینه بین (پرداخت) و (واریز) انتخاب نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         
                    }
                }
                else
                {
                    MessageBox.Show("لطفا مقدار و یک شخص را انتخاب نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            
        }
    }
}
