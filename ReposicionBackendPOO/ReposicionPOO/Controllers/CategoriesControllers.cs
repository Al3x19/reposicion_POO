using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReposicionPOO.Services;
using ReposicionPOO.Services.Interfaces;

namespace ReposicionPOO.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesControllers : ControllerBase
    {
        private readonly ICategoriesService _categoriesService;

        public CategoriesControllers(ICategoriesService categoriesService)
        {
            this._categoriesService = categoriesService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            return Ok(await _categoriesService.GetCategoriesAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(Guid id)
        {
            var category = await _categoriesService.GetCategoriesByIdAsync(id);

            if (category == null)
            {
                return NotFound(new { Message = $"No se encontro la categoría: {id}" });
            }

            return Ok(category);
        }

    }
}
