using Elearning.Models.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Models.DAL
{
    interface DAO_Location : DAO_Interface<Location>
    {
        Location FindbyId(int id);
    }
}
