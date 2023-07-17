using Meireles.Messaging.Contract;
using Meireles.Messaging.Contract.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Meireles.Messaging.Producer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProducerController : ControllerBase
    {
        private readonly ISender _sender;
        public ProducerController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await _sender.PublishAsync(new Employee { Name = "Custom name"});
            await _sender.PublishAsync(new Product { Name = "Custom product"});
            return Ok();
        }
    }
}