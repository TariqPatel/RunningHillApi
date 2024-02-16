using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class NounsController: ControllerBase
    {
        private static readonly string[] Nouns = new[]
        {
            "Nouns", "Nouns", "Nouns", "Nouns", "Nouns", "Nouns", "Nouns", "Nouns", "Nouns", "Nouns"
        };

        private readonly ILogger<NounsController> _logger;

        public NounsController(ILogger<NounsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetNouns")]
        public IEnumerable<Noun> Get()
        {
            return Enumerable.Range(1, Nouns.Length).Select(index => new Noun
            {
                Word = Nouns[Random.Shared.Next(Nouns.Length)]
            })
            .ToArray();
        }
    }
}