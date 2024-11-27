using Microsoft.AspNetCore.Mvc;
using QuizYnovBack.Business.Models;

namespace QuizYnovBack.Business {
    public interface IQuizService
    {
        IEnumerable<Quiz> GetAll();

        Quiz GetQuiz(Guid Id);
    }
}