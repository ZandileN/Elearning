using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Models.DAL.DAO
{
    interface DAO_Interface<T>
    {
       List<T> FindAll();
       bool Persist(T entity);
       bool Merge(T entity);
       bool Remove(T entity);
    }
}
