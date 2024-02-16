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
            "above", "across", "against", "along", "around", "before", "down", "under", "beneath", "off"
        };

        private readonly ILogger<PrepositionController> _logger;

        public PrepositionController(ILogger<PrepositionController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPrepositions")]
        public IEnumerable<Preposition> Get()
        {
            return Enumerable.Range(0, Prepositions.Length).Select(index => new Preposition
            {
                Word = Prepositions[index]
            })
            .ToArray();
        }
    }
}