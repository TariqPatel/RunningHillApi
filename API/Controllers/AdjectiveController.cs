using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AdjectiveController: ControllerBase
    {
        private static readonly string[] Adjective = new[]
        {
            "Adjective", "Adjective", "Adjective", "Adjective", "Adjective", "Adjective", "Adjective", "Adjective", "Adjective", "Adjective"
        };

        private readonly ILogger<AdjectiveController> _logger;

        public AdjectiveController(ILogger<AdjectiveController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAdjectives")]
        public IEnumerable<Adjective> Get()
        {
            return Enumerable.Range(1, Adjective.Length).Select(index => new Adjective
            {
                Word = Adjective[Random.Shared.Next(Adjective.Length)]
            })
            .ToArray();
        }
    }
}