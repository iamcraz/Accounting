using Accounting_Viewmodel.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_Datalayer
{
    public interface ICoustomerRepository
    {
        List<Customers> GetAllCustomers();

        Customers GetCustomersById(int Customer_id);

        List<ListCustomerViewModel> getNames(string filter = "");

        bool InsertCustomer(Customers customer);

        bool UpdateCustomer(Customers customer);

        bool DeleteCustomer(Customers customer);

        bool DeleteCustomer(int customer_id);

        List<Customers> SearchCustomer(string Customer_name);
        string GetCustomerNameById(int id);
        int GetCustomerIdByName(string name);
        void Save();
    }
}
