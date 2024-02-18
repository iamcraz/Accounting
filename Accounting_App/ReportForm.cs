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
using Accounting_Utilities;
using Accounting_Viewmodel.Customers;

namespace Accounting_App
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        public int type = 0;
        private void ReportForm_Load(object sender, EventArgs e)
        {
            using (Unitofwork db=new Unitofwork())
            {
                List<ListCustomerViewModel> list = new List<ListCustomerViewModel>();
                list.Add(new ListCustomerViewModel()
                {
                    Customer_fullname = "همه",
                    Customer_id = 0,
                });
                list.AddRange(db.Customer_Repository.getNames());
                comboBox.DataSource = list;
                comboBox.DisplayMember = "Customer_fullname";
                comboBox.ValueMember = "Customer_id";
            }
            
            if (type == 1)
            {
                this.Text = "فرم گزارشات واریزی ها ";

            }
            else
            {
                this.Text = "فرم گزارشات پرداختی ها ";
            }

            RefLoadall();

        }
        public string customer_name;
        private void RefLoadall() 
        {
            try
            {
                int selected = int.Parse(comboBox.SelectedValue.ToString());

                DateTime? start_date;
                DateTime? end_date;

                List<Accounting_> result = new List<Accounting_>();

                int check = 0;

                if (selected == 0)
                {
                    using (Unitofwork db = new Unitofwork())
                    {
                        result.AddRange(db.Accounting_Repository.getall(r => r.Type_ID == type).ToList());
                    }
                    check = 0;
                }
                else
                {
                    using (Unitofwork db = new Unitofwork())
                    {
                        result.AddRange(db.Accounting_Repository.getall(r => r.Type_ID == type && r.Customer_ID == selected).ToList());
                    }
                    check = 1;

                }
                if (StartDateBox.Text != "    /  /")
                {
                    start_date = Convert.ToDateTime(StartDateBox.Text);
                    start_date = utliti.TOmiladi(start_date.Value);
                    using (Unitofwork db = new Unitofwork())
                    {
                        result = result.Where(r => r.Date_time >= start_date).ToList();
                    }

                }
                if (EndDateBox.Text != "    /  /")
                {
                    end_date = Convert.ToDateTime(EndDateBox.Text);
                    end_date = utliti.TOmiladi(end_date.Value);
                    using (Unitofwork db = new Unitofwork())
                    {
                        result = result.Where(r => r.Date_time <= end_date).ToList();
                    }
                }



                DgvReport.Rows.Clear();

                foreach (var account in result)
                {
                    using (Unitofwork db = new Unitofwork())
                    {
                        customer_name = db.Customer_Repository.GetCustomerNameById(account.Customer_ID);
                    }
                    DgvReport.Rows.Add(account.ID, account.Customer_ID, customer_name, account.Amount, account.Discription, utliti.TOshamsi(account.Date_time));


                }

                DgvReport.AutoGenerateColumns = false;
            }
            catch
            {
                MessageBox.Show("تاریخ ها را دقیق و درست و شمسی وارد کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            RefLoadall();
        }

        private void delbtn_Click(object sender, EventArgs e) 
        {
            if (DgvReport.CurrentRow != null)
            {    
                var result=MessageBox.Show($" آیا اطمینان از حذف دارید ؟ ","هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    using (Unitofwork db = new Unitofwork())
                    {
                        int id = int.Parse(DgvReport.CurrentRow.Cells[0].Value.ToString());

                        db.Accounting_Repository.delete(id);
                        db.save();
                    }
                    RefLoadall();
                }
               
            }
            else
            {
                MessageBox.Show("یک ردیف را انتخاب نمایید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            int accounting_id = int.Parse(DgvReport.CurrentRow.Cells[0].Value.ToString());
            New_trans_form frm = new New_trans_form();
            frm.accounting_id =accounting_id;
            
            frm.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                RefLoadall();
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            RefLoadall();   
        }
    }
}
