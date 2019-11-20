using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractDataBase
{
    public interface IFindAccount<T>
    {
        public T FindAccountByNumber(string num);

        public void DisposeMyContext();

        public void Update();
    }
}
