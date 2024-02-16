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
            "I", "you", "he", "she", "it", "we", "they"
        };

        private readonly ILogger<PronounController> _logger;

        public PronounController(ILogger<PronounController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPronouns")]
        public IEnumerable<Pronoun> Get()
        {
            return Enumerable.Range(0, Pronouns.Length).Select(index => new Pronoun
            {
                Word = Pronouns[index]
            })
            .ToArray();
        }
    }
}