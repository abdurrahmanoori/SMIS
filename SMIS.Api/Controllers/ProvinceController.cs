using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Application.Common;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.Features.Provinces.Commands;
using SMIS.Application.Features.Provinces.Queries;
using SMIS.Api.Controllers.Base;

namespace SMIS.Api.Controllers
{
    /// <summary>
    /// Manages provinces used in addresses and location data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceController : BaseApiController
    {
        /// <summary>
        /// Deliberately throws an exception to test API error handling.
        /// </summary>
        /// <remarks>
        /// This is a development/testing endpoint. It does not return province data and should not be used as a normal application endpoint.
        /// </remarks>
        [HttpGet("test")]
        public IActionResult Get()
        {
            throw new Exception("test data from provice controller.");
        }

        /// <summary>
        /// Creates a new province.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<ProvinceDto>> Create(
            ProvinceCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ProvinceCreateCommand(dto)));

        /// <summary>
        /// Gets provinces in pages.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<PagedList<ProvinceDto>>> GetAll(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 25
        )
        {
            return HandleResultResponseOld(await Mediator.Send(new ProvinceGetListQuery(pageNumber, pageSize)));
        }

        /// <summary>
        /// Gets one province by its ID.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<ProvinceDto>> GetById(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ProvinceGetByIdQuery(id)));

        /// <summary>
        /// Updates an existing province.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<ProvinceDto>> Update(
            string id,
            ProvinceCreateDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ProvinceUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a province.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ProvinceDeleteCommand(id)));
    }
}