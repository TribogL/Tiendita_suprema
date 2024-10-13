
using Microsoft.AspNetCore.Mvc;
using Tiendita_suprema.DTOs;
using Tiendita_suprema.Repositories;

namespace Tiendita_suprema.Controllers.V1.Categories;
[ApiController]
[Route("api/v1/categories")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("categories")]
public class CategoryPostController(ICategoryRepository categoryRepository) : CategoryController(categoryRepository)
{
    [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryDTO newCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await categoryRepository.Create(newCategory);

            return Ok("Category added successfully.");
        }

}
