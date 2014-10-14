using Elearning.Models.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Models.Services
{
    interface QuizingServices: IDisposable
    {

        List<Question> DisplayQuestions(int policyID, int version);
        List<Answer> DisplayAnswer(List<Question> question);

        int TotalMarkAfterQuiz(List<AnswerDTO> ans);

    }
}
