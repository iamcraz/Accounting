using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Accounting_Viewmodel.Customers;

namespace Accounting_Datalayer
{
    public class CustomerRepository : ICoustomerRepository
    {
        private Accounting_DBEntities db;
        public CustomerRepository(Accounting_DBEntities context)
        {
            db = context;
        }

        

        public bool DeleteCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(int customer_id)
        {
            try
            {
                var customer=GetCustomersById(customer_id);
                DeleteCustomer(customer);
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public int GetCustomerIdByName(string name)
        {
            return db.Customers.First(x => x.Customer_fullname == name).Customer_id;
        }
        

        public string GetCustomerNameById(int id)
        {
            return db.Customers.First(x => x.Customer_id == id).Customer_fullname;
        }

        public Customers GetCustomersById(int Customer_id)
        {
            return db.Customers.Find(Customer_id);
        }

        public List<ListCustomerViewModel> getNames(string filter = "")
        {
            if (filter == "")
            {
                return db.Customers.Select(x => new ListCustomerViewModel()
                {
                    Customer_fullname = x.Customer_fullname,
                    Customer_id= x.Customer_id,
                }
                ).ToList();

            }
            else
            {
                return db.Customers.Where(x => x.Customer_fullname.Contains(filter)).Select(c => new ListCustomerViewModel()
                {
                    Customer_fullname = c.Customer_fullname,
                    Customer_id = c.Customer_id,
                }).ToList();
            }
        }

        public bool InsertCustomer(Customers customer)
        {
            try
            {
                db.Customers.Add(customer);
                Save();
                return true;
            }
            catch
            {
                return false;
            }
                        
        }

        public void Save()
        {
            db.SaveChanges();
            
        }

        public List<Customers> SearchCustomer(string Customer_name)
        {
            
            return db.Customers.Where(x => x.Customer_fullname.Contains(Customer_name)).ToList(); 
           
        }

        public bool UpdateCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Modified;
                Save();
                return true;
            }
            catch
            {
                return false;
            }

        }

      

        /*public bool check_exist(Customers customer)
        {
            try
            {
                List<Customers> customer_new = new List<Customers>();
                customer_new=db.Customers.Where(x => x.Customer_fullname == customer.Customer_fullname || x.Customer_mobile == customer.Customer_mobile || x.Customer_Email == customer.Customer_Email).ToList();
                if (customer_new==null)
                {

                }
                return true;
            }
            catch
            {
                return false;
            }
        }*/

    }
}
