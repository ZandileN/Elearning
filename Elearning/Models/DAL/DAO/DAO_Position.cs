using Elearning.Models.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Models.DAL
{
    interface DAO_Position : DAO_Interface<Position>
    {
        Position FindById(int id);
    }
}
