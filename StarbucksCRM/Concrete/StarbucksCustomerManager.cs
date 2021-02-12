using StarbucksCRM.Abstract;
using StarbucksCRM.Adapters;
using StarbucksCRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbucksCRM.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService customerCheck;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            customerCheck = customerCheckService;
        }

        public override void Save(Customer customer)//abstract classdaki save metoduna override yaptim ve mernis dogrulamasi implemente edecem.
        {
            if (customerCheck.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
            
        }

        /*private void CheckIfRealPerson(Customer customer)
        {
           Bu yapilabilir ama yarin baska bi sirkette mernis dogrulamasi isterse bunu kopyala yapistir yapmak gerekir. onun yerine bu isi yapacak bi interface yapalim
        //bunun yerine  ICustomerCheckService ile CustomerCheckManageri yaptim. Bu classlarla operasyon yapabilirim istedigim sirket icin.
        }*/

        //mernis ten yararlanabilmek icin su linki kullanacaz-->https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx?op=TCKimlikNoDogrula
    }
}
