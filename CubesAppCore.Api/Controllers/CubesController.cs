using CubesAppCore.Api.Models;

using Microsoft.AspNetCore.Mvc;

namespace CubesAppCore.Api.Controllers
{
    [Route("api/v1/[controller]")]
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
        public IActionResult Volume([FromBody] CubesRequestModel requestModel)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            /*this peace of code should go outside the controller in another class or another layer
            * also we should Use DTOs to move data back and forth and keep 
            * controllers as thin as possible. It is a good practice to use async/await
            * if possible. We should also think versioning as business changes.
            * It shouldbe also noted caching significantly improve performance/user experience.
            * API documentation is also extremely vital.
            */
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
                logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
