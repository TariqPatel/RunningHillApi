using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ConjunctionController: ControllerBase
    {
        private static readonly string[] Conjunctions = new[]
        {
            "Conjunctions", "Conjunctions", "Conjunctions", "Conjunctions", "Conjunctions", "Conjunctions", "Conjunctions", "Conjunctions", "Conjunctions", "Conjunctions"
        };

        private readonly ILogger<ConjunctionController> _logger;

        public ConjunctionController(ILogger<ConjunctionController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetConjunctions")]
        public IEnumerable<Conjunction> Get()
        {
            return Enumerable.Range(1, Conjunctions.Length).Select(index => new Conjunction
            {
                Word = Conjunctions[Random.Shared.Next(Conjunctions.Length)]
            })
            .ToArray();
        }
    }
}