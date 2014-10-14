using Elearning.Models.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Models.Services
{
    interface EmployeeServices : IDisposable
    {
        Policy FailedPolicy(List<AnswerDTO> ans);
        int PolicyMark(int policyID, int version, int empID);

      

    }
}
