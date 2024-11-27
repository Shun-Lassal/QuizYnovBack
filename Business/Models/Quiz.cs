using System.ComponentModel;
using System.Globalization;
using Microsoft.Net.Http.Headers;

namespace QuizYnovBack.Business.Models
{
    public class Quiz
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Difficulty { get; set; }
        public Category Category { get; set; }

        public IEnumerable<Question> Questions { get; set; }

        public DateTime DatePublication { get; set; }

    }
}