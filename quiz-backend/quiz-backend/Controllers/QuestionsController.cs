using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using quiz_core.Framework;
using quiz_core.Quizes;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace quiz_backend.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly ILogger<QuestionsController> _logger;

        public QuestionsController(ILogger<QuestionsController> logger)
        {
            _logger = logger;
        }

        // POST api/<QuestionsController>
        [HttpPost]
        public void Post([FromBody] QuizQuestionModel question)
        {

        }


        // GET: api/<QuestionsController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SearchResult<QuizQuestionModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ValidationProblemDetails))]
        public async Task<ActionResult<SearchResult<QuizQuestionModel>>> SearchQuizQuestions(
        [FromQuery] QuizQuestionSearch search,
        [FromServices] IQuizRepository quizRepository)
        {
            var result = await quizRepository.SearchQuestions(search);
            return Ok(result);
        }


        // GET api/<QuestionsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // PUT api/<QuestionsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<QuestionsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
