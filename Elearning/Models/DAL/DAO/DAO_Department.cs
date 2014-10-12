using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Elearning.Models.DAL.DAO;namespace Elearning.Models.DAL
{
    interface DAO_Department : DAO_Interface<Department>
    {
        List<Department> FindById(string name);
    }
}
