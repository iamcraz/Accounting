using Accounting_Datalayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_Datalayer
{
    public class Unitofwork : IDisposable
    {
        Accounting_DBEntities db = new Accounting_DBEntities();

        private CustomerRepository _customerRepository;
        public CustomerRepository Customer_Repository { 
            get {
                    if (_customerRepository == null)
                    {
                    _customerRepository = new CustomerRepository(db);
                    }
                    return _customerRepository;
            } 
        }

        private GenericRepository<Accounting_> _accountingRepository;
        
        public GenericRepository<Accounting_> Accounting_Repository
        {
            get
            {
                if (_accountingRepository == null)
                {
                    _accountingRepository = new GenericRepository<Accounting_>(db);
                }

                return _accountingRepository;
            }
        }

        private GenericRepository<login> _loginrepository;

        public GenericRepository<login> LoginRepository
        {
            get
            {
                if (_loginrepository == null)
                {
                    _loginrepository = new GenericRepository<login>(db);
                }

                return _loginrepository;
            }
        }
        

        public void Dispose()
        {
            db.Dispose();
        }

        public void save()
        {
            db.SaveChanges();
        }

        
    }
}
