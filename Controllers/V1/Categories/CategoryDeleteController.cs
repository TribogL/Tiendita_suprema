
using Microsoft.AspNetCore.Mvc;
using Tiendita_suprema.Repositories;

namespace Product_manager.Controllers.V1.Categories;
[ApiController]
[Route("api/v1/categories")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("categories")]
public class CategoryDeleteController(ICategoryRepository categoryRepository) : CategoryController(categoryRepository)
{
    [HttpDelete("{id}")]

    public async Task<IActionResult> Delete(int id)
    {
        var category = await _categoryRepository.CheckExistence(id);

        if (category == false)
        {
            return NotFound();
        }

        await _categoryRepository.Delete(id);

        return NotFound();
    }
}
