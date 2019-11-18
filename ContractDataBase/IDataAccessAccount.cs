using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractDataBase
{
    public interface IDataAccessAccount<T>
    {
        public void InsertAccount(T account);


        public T FindAccountByNumber(string num);


        public void DisposeMyContext();

    }
}
