
using Microsoft.AspNetCore.Mvc;
using Tiendita_suprema.Repositories;

namespace Tiendita_suprema.Controllers.V1.Categories;
[ApiController]
[Route("api/v1/categories")]
public class CategoryController(ICategoryRepository categoryRepository) : ControllerBase
{
    protected readonly ICategoryRepository _categoryRepository = categoryRepository;
}

