using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface IRepositorio<T> where T : class
    {
        bool Add(T pT);

        bool Remove(T pT);

        bool Update(T pT);

        T FindById(object pId);

        IEnumerable<T> FindAll();
    }
}
