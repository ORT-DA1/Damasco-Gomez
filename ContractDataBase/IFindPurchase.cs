using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractDataBase
{
    public interface IFindPurchase<T>
    {

        public List<T> FindPurchaseByLicense(string license);

        public void DisposeMyContext();
    }
}
