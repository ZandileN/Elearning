﻿using Elearning.Models.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Models.DAL
{
    interface DAO_Policy : DAO_Interface<Policy>
    {
        Policy FindById(int reference);
    }
}
