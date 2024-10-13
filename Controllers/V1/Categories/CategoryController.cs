
using Microsoft.AspNetCore.Mvc;
using Tiendita_suprema.Repositories;

namespace Product_manager.Controllers.V1.Categories;
[ApiController]
[Route("api/v1/productcategories")]
public class CategoryController(ICategoryRepository categoryRepository) : ControllerBase
{
    protected readonly ICategoryRepository _categoryRepository = categoryRepository;
}

