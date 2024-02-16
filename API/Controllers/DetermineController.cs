using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class DetermineController: ControllerBase
    {
        private static readonly string[] Determines = new[]
        {
            "Determines", "Determines", "Determines", "Determines", "Determines", "Determines", "Determines", "Determines", "Determines", "Determines"
        };

        private readonly ILogger<DetermineController> _logger;

        public DetermineController(ILogger<DetermineController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetDetermines")]
        public IEnumerable<Determine> Get()
        {
            return Enumerable.Range(1, Determines.Length).Select(index => new Determine
            {
                Word = Determines[Random.Shared.Next(Determines.Length)]
            })
            .ToArray();
        }
    }
}