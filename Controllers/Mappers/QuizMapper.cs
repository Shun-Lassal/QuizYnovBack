using QuizYnovBack.Business.Models;
using QuizYnovBack.Controllers.Dtos;

namespace QuizYnovBack.Controllers.Mappers 
{
    public class QuizMapper 
    {
        public QuizDto ToDto (Quiz quiz)
        {
            return new QuizDto 
            {
                Id = quiz.Id,
                Description = quiz.Description, 
                Difficulty = quiz.Difficulty,
                Name = quiz.Name,
                CategoryId = quiz.Category.Id,
                DatePublication = quiz.DatePublication
            };
        }
    }
}