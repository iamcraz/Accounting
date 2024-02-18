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
    public partial class AddOrEditform : Form
    {
       

        public int Customer_id = 0;

        public AddOrEditform()
        {
            InitializeComponent();

         
        }

        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile_pic = new OpenFileDialog();
            
            if (openfile_pic.ShowDialog()== DialogResult.OK)
            {
                picbox.ImageLocation = openfile_pic.FileName;
            }
        }

        private void AddOrEditform_Load(object sender, EventArgs e)
        {
            if (Customer_id == 0)
            {
                this.Text = "اضافه کردن شخص جدید";
                
            }
            else
            {
                this.Text = "ویرایش";
                Customers customer = new Customers();

                using(Unitofwork db=new Unitofwork())
                {
                    customer = db.Customer_Repository.GetCustomersById(Customer_id);
                }
                
                nametxt.Text = customer.Customer_fullname;
                mobiletxt.Text = customer.Customer_mobile;
                emailtxt.Text = customer.Customer_Email;
                addresstxt.Text = customer.Customer_address;
                picbox.ImageLocation = Application.StartupPath + $"/Images/"+customer.Customer_image;
            }
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string image_name = Guid.NewGuid().ToString() + Path.GetExtension(picbox.ImageLocation);
                string path = Application.StartupPath + $"/Images/";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    picbox.Image.Save(path + image_name);
                }
                else 
                {
                    picbox.Image.Save(path + image_name);
                }

                Customers customer = new Customers()
                {
                    Customer_id = Customer_id,
                    Customer_fullname = nametxt.Text,
                    Customer_mobile = mobiletxt.Text,
                    Customer_Email = emailtxt.Text,
                    Customer_address = addresstxt.Text,
                    Customer_image = image_name,
                };


                using (Unitofwork db = new Unitofwork())
                {
                    if (Customer_id == 0)
                    {

                        if (db.Customer_Repository.InsertCustomer(customer))
                        {


                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            DialogResult = DialogResult.Cancel;
                        }
                    }
                    else
                    {
                        if (db.Customer_Repository.UpdateCustomer(customer))
                        {
                            DialogResult = DialogResult.OK;

                        }
                        else
                        {
                            DialogResult = DialogResult.Cancel;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("خطا", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {

            }

            
            
            
            

        }
    }
}
