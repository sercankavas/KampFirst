using StarbucksCRM.Abstract;
using StarbucksCRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbucksCRM.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService checkService;

        public NeroCustomerManager(ICustomerCheckService checkService)
        {
            this.checkService = checkService;
        }

        public override void Save(Customer customer)
        {
            if (checkService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
