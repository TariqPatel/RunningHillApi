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
            "Verbs", "Verbs", "Verbs", "Verbs", "Verbs", "Verbs", "Verbs", "Verbs", "Verbs", "Verbs"
        };

        private readonly ILogger<VerbController> _logger;

        public VerbController(ILogger<VerbController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetVerbss")]
        public IEnumerable<Verb> Get()
        {
            return Enumerable.Range(1, Verbs.Length).Select(index => new Verb
            {
                Word = Verbs[Random.Shared.Next(Verbs.Length)]
            })
            .ToArray();
        }
    }
}