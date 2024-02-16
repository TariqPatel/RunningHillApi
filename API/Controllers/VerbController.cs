using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class VerbController: ControllerBase
    {
        private static readonly string[] Verbs = new[]
        {
            "agree", "concur", "attack", "snap", "shout", "strive", "plead", "inquire", "request", "bloom"
        };

        private readonly ILogger<VerbController> _logger;

        public VerbController(ILogger<VerbController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetVerbss")]
        public IEnumerable<Verb> Get()
        {
            return Enumerable.Range(0, Verbs.Length).Select(index => new Verb
            {
                Word = Verbs[index]
            })
            .ToArray();
        }
    }
}