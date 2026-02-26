using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMIS.Api.Controllers.Base;
using SMIS.Application.Common;
using SMIS.Application.DTO.Categories;
using SMIS.Application.Features.Categories.Commands;
using SMIS.Application.Features.Categories.Queries;

namespace SMIS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : BaseApiController
    {

        [HttpPost]
        public async Task<ActionResult<CategoryDto>> Create(CategoryCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new CategoryCreateCommand(dto)));

        [HttpGet]
        public async Task<ActionResult<PagedList<CategoryDto>>> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25)
        {
            return HandleResultResponse(await Mediator.Send(new CategoryGetListQuery(pageNumber, pageSize)));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDto>> GetById(string id) =>
            HandleResultResponse(await Mediator.Send(new CategoryGetByIdQuery(id)));

        [HttpPut("{id}")]
        public async Task<ActionResult<CategoryDto>> Update(string id, CategoryCreateDto dto) =>
            HandleResultResponse(await Mediator.Send(new CategoryUpdateCommand(id, dto)));

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(string id) =>
            HandleResultResponse(await Mediator.Send(new CategoryDeleteCommand(id)));
    }
}