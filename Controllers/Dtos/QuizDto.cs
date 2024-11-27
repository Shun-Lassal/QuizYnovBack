namespace QuizYnovBack.Controllers.Dtos

{
    public class QuizDto

    {        
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Difficulty { get; set; }
        public Guid CategoryId { get; set;}

        public DateTime DatePublication { get; set; }
    }

}