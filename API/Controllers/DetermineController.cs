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
            "learn", "determine", "certainty"
        };

        private readonly ILogger<DetermineController> _logger;

        public DetermineController(ILogger<DetermineController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetDetermines")]
        public IEnumerable<Determine> Get()
        {
            return Enumerable.Range(0, Determines.Length).Select(index => new Determine
            {
                Word = Determines[index]
            })
            .ToArray();
        }
    }
}