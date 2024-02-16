using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PrepositionController: ControllerBase
    {
        private static readonly string[] Prepositions = new[]
        {
            "Prepositions", "Prepositions", "Prepositions", "Prepositions", "Prepositions", "Prepositions", "Prepositions", "Prepositions", "Prepositions", "Prepositions"
        };

        private readonly ILogger<PrepositionController> _logger;

        public PrepositionController(ILogger<PrepositionController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPrepositions")]
        public IEnumerable<Preposition> Get()
        {
            return Enumerable.Range(1, Prepositions.Length).Select(index => new Preposition
            {
                Word = Prepositions[Random.Shared.Next(Prepositions.Length)]
            })
            .ToArray();
        }
    }
}