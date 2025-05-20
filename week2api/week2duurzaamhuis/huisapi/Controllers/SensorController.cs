using Microsoft.AspNetCore.Mvc;
using JouwProject.Models;

namespace JouwProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SensorController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Sensoren> GetSensoren()
        {
            var data = new Sensoren
            {
                ldr = 100,
                dht = new DHT
                {
                    temperature = 25,
                    humidity = 11,
                    heatIndex = 6
                }
            };

            return Ok(data);
        }
    }
}
