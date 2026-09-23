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
    /// Manages translated province names and other province text.
    /// </summary>
    /// <remarks>
    /// A province can have separate translation records for different languages.
    /// </remarks>
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceTranslationController : BaseApiController
    {
        /// <summary>
        /// Creates a translation for a province.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<ProvinceTranslationDto>> Create(
            ProvinceTranslationDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ProvinceTranslationCreateCommand(dto)));

        /// <summary>
        /// Gets all translations for one province.
        /// </summary>
        /// <param name="provinceId">The province ID.</param>
        [HttpGet("province/{provinceId}")]
        public async Task<ActionResult<List<ProvinceTranslationDto>>> GetByProvince(
            string provinceId
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ProvinceTranslationGetListQuery(provinceId)));

        /// <summary>
        /// Gets one province translation by its ID.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<ProvinceTranslationDto>> GetById(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ProvinceTranslationGetByIdQuery(id)));

        /// <summary>
        /// Updates an existing province translation.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<ProvinceTranslationDto>> Update(
            string id,
            ProvinceTranslationDto dto
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ProvinceTranslationUpdateCommand(id, dto)));

        /// <summary>
        /// Deletes a province translation.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(
            string id
        ) =>
            HandleResultResponseOld(await Mediator.Send(new ProvinceTranslationDeleteCommand(id)));
    }
}