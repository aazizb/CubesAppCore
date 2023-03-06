using CubesAppCore.Api.Models;

using Microsoft.AspNetCore.Mvc;

namespace CubesAppCore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CubesController : ControllerBase
    {
        private readonly ILogger<CubesController> logger;

        public CubesController(ILogger<CubesController> logger)
        {
            this.logger = logger;
        }
        /// <summary>
        /// Computes the common volume between two cubes if they cillide
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GetCommonVolume([FromBody] CubesRequestModel requestModel)
        {
            //this peace of code should go in another class out side the controller
            try
            {
                Cube cubeA = new CubeBuilder()
                    .WithCenter(requestModel.PointA)
                    .WithLength(requestModel.LengthA)
                    .Build();
                Cube cubeB = new CubeBuilder()
                   .WithCenter(requestModel.PointB)
                   .WithLength(requestModel.LengthB)
                   .Build();
                double volume = cubeA.CommonVolumeWith(cubeB);
                return Ok(volume);

            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message, ex);
                return BadRequest();
            }
        }
    }
}
