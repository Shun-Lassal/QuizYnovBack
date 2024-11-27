using QuizYnovBack.Business.Models;

namespace QuizYnovBack.Business.Services 
{
  public class QuizService : IQuizService
  {
    private List<Quiz> _quizList = new List<Quiz>
    {
      new Quiz
      {
        Id = new Guid("759da5d3-6f0d-4463-a298-584ff7b2406e"),
        Category = new Category{Id = new Guid("95939cc1-c138-4ec4-b3a8-9427262a1abb")},
        Description = "ASP.NET Core, Angular, etc.",
        Difficulty = 3,
        Name = "Dev fullstack M1",
        DatePublication = DateTime.Now
      }
    };

    public IEnumerable<Quiz> GetAll()
    {
      return _quizList;
    }

    public Quiz GetQuiz(Guid Id)
    {
      var quiz = _quizList.FirstOrDefault(q => q.Id == Id);
      return quiz;
    }
  }
}