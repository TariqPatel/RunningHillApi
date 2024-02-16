using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ExclamationController: ControllerBase
    {
        private static readonly string[] Exclamations = new[]
        {
            "ouch", "yuck", "ugh", "yikes", "shoot", "whoops", "rats", "gosh", "congratulations", "cheers"
        };

        private readonly ILogger<ExclamationController> _logger;

        public ExclamationController(ILogger<ExclamationController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetExclamations")]
        public IEnumerable<Exclamation> Get()
        {
            return Enumerable.Range(0, Exclamations.Length).Select(index => new Exclamation
            {
                Word = Exclamations[index]
            })
            .ToArray();
        }
    }
}