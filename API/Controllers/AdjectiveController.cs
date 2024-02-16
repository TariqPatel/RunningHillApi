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
            "beautiful", "witty", "wicked", "confusing", "rich", "new", "strange", "rocky"
        };

        private readonly ILogger<AdjectiveController> _logger;

        public AdjectiveController(ILogger<AdjectiveController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAdjectives")]
        public IEnumerable<Adjective> Get()
        {
            return Enumerable.Range(0, Adjective.Length).Select(index => new Adjective
            {
                Word = Adjective[index]
            })
            .ToArray();
        }
    }
}