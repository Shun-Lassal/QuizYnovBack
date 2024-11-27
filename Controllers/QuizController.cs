using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizYnovBack.Business;
using QuizYnovBack.Business.Models;
using QuizYnovBack.Controllers.Dtos;
using QuizYnovBack.Controllers.Mappers;

namespace QuizYnovBack.Controllers
{
    [Route("api/quiz")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly IQuizService _service;
        private readonly QuizMapper _mapper;

        public QuizController(IQuizService service, QuizMapper mapper) {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetAllQuiz")]
        [ProducesResponseType(typeof(IEnumerable<QuizDto>), 200)]
        public IActionResult GetAll()
        {
            IEnumerable<QuizDto> dtos = _service.GetAll().Select(quiz => _mapper.ToDto(quiz));
            return Ok(dtos);
        }

        [HttpGet("{Id}", Name = "GetQuiz")]
        [ProducesResponseType(typeof(QuizDto), 200)]
        public IActionResult GetQuiz(Guid Id)
        {
            Quiz quiz = _service.GetQuiz(Id);

            if (quiz == null)
            {
                return NotFound();
            }
            QuizDto dto = _mapper.ToDto(quiz);
            return Ok(dto);
        }
        
    }

}
