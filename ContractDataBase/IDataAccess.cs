using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractDataBase
{
    public interface IDataAccess<T>
    {
        public void Insert(T elem);


        public void DisposeMyContext();

        public void DeleteDataBase();

        public List<T> AllData();

    }
}
