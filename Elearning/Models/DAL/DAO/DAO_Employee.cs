using Elearning.Models.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Models.DAL
{
    interface DAO_Employee : DAO_Interface<Employee>
    {
        Employee FindById(string firstname, string lastname);
    }
}
