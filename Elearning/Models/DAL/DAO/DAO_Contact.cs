using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Models.DAL.DAO
{
    interface DAO_Contact : DAO_Interface<Contact>
    {
        Contact FindByID(string name);

    }

}
