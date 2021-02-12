using StarbucksCRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbucksCRM.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
