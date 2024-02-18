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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Pass_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            

        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            using(Unitofwork db=new Unitofwork())
            {
                var result=db.LoginRepository.getall(x => x.Username == UserNametxt.Text && x.Userpass == PassWordtxt.Text).Any();
                if (result==true)
                {
                    DialogResult = DialogResult.OK;
                }
                
            }
        }
    }
}
