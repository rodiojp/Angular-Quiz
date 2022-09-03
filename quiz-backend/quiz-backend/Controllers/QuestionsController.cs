using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using quiz_backend.Models;
using System.Collections.Generic;

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
        public void Post([FromBody] Question question)
        {

        }

        // GET: api/<QuestionsController>
        [HttpGet]
        public IEnumerable<Question> Get()
        {
            return new Question[] { new Question { Text = "value1" }, new Question { Text = "value2" } };
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
