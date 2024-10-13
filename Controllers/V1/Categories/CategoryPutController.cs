
using Microsoft.AspNetCore.Mvc;
using Tiendita_suprema.DTOs;
using Tiendita_suprema.Repositories;

namespace Product_manager.Controllers.V1.Categories;
[ApiController]
[Route("api/v1/categories")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("categories")]
public class CategoryPutController(ICategoryRepository categoryRepository) : CategoryController(categoryRepository)
{
    [HttpPut]
    public async Task<IActionResult> UpdateCustomer(int id, CategoryDTO updateCategory)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var category = await categoryRepository.GetById(id);

        if (category == null)
            return NotFound();

        await categoryRepository.Update(id, updateCategory);

        return Ok(category);
    }

}
