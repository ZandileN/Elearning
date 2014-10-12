using Elearning.Models.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Models.DAL
{
    interface DAO_Score : DAO_Interface<Score>
    {
        Score FindById (int id);
    }
}
