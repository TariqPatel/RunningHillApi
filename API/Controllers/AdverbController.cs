using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AdverbController: ControllerBase
    {
        private static readonly string[] Adverbs = new[]
        {
            "Adverbs", "Adverbs", "Adverbs", "Adverbs", "Adverbs", "Adverbs", "Adverbs", "Adverbs", "Adverbs", "Adverbs"
        };

        private readonly ILogger<AdverbController> _logger;

        public AdverbController(ILogger<AdverbController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAdverbs")]
        public IEnumerable<Adverb> Get()
        {
            return Enumerable.Range(1, Adverbs.Length).Select(index => new Adverb
            {
                Word = Adverbs[Random.Shared.Next(Adverbs.Length)]
            })
            .ToArray();
        }
    }
}