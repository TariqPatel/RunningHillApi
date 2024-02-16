using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ExclamationController: ControllerBase
    {
        private static readonly string[] Exclamations = new[]
        {
            "Exclamations", "Exclamations", "Exclamations", "Exclamations", "Exclamations", "Exclamations", "Exclamations", "Exclamations", "Exclamations", "Exclamations"
        };

        private readonly ILogger<ExclamationController> _logger;

        public ExclamationController(ILogger<ExclamationController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetExclamations")]
        public IEnumerable<Exclamation> Get()
        {
            return Enumerable.Range(1, Exclamations.Length).Select(index => new Exclamation
            {
                Word = Exclamations[Random.Shared.Next(Exclamations.Length)]
            })
            .ToArray();
        }
    }
}