using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParkBee.Services.Interfaces;

namespace ParkBee.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Garages")]
    public class GaragesController : Controller
    {
        #region Fields
        private readonly IGaragesService _garagesService;
        #endregion

        #region Contracture
        public GaragesController(IGaragesService garagesService)
        {
            _garagesService = garagesService;
        }
        #endregion

        #region GET Actions
        [HttpGet]
        public async Task<IActionResult> Get(int pageNumber, int pageSize, string keyword = null)
        {
            var result = await _garagesService.Get(--pageNumber, pageSize, keyword);
            return Ok(result);
        }

        [HttpGet(), Route("{id}")]
        public IActionResult Get(Guid id)
        {
            var result = _garagesService.GetGarageById(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        #endregion

        #region POST Actions
        [HttpPost]
        public IActionResult Post([FromBody] BindingModels.Garage garageBindingModel)
        {
            var result = _garagesService.Add(garageBindingModel);
            return Ok(result);
        }
        #endregion

        #region PUT Actions
        [HttpPut, Route("{id}")]
        public IActionResult Put([FromQuery]Guid id, [FromBody] BindingModels.Garage garageBindingModel)
        {
            if (id != garageBindingModel.Id) return BadRequest("Garage ID is not same.");

            bool result = _garagesService.Update(garageBindingModel);

            if (result) return Ok();
            return NotFound();
        }
        #endregion

        #region DELETE Actions
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(Guid id)
        {
            bool result = _garagesService.Delete(id);

            if (result) return Ok();
            return NotFound();
        }
        #endregion
    }
}