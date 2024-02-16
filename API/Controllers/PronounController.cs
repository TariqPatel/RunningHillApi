using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PronounController: ControllerBase
    {
        private static readonly string[] Pronouns = new[]
        {
            "Pronouns", "Pronouns", "Pronouns", "Pronouns", "Pronouns", "Pronouns", "Pronouns", "Pronouns", "Pronouns", "Pronouns"
        };

        private readonly ILogger<PronounController> _logger;

        public PronounController(ILogger<PronounController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPronouns")]
        public IEnumerable<Pronoun> Get()
        {
            return Enumerable.Range(1, Pronouns.Length).Select(index => new Pronoun
            {
                Word = Pronouns[Random.Shared.Next(Pronouns.Length)]
            })
            .ToArray();
        }
    }
}