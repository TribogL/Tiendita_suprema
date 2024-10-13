
using Tiendita_suprema.DTOs;
using Tiendita_suprema.Models;

namespace Tiendita_suprema.Repositories;
public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAll();
    Task<Category?> GetById(int id);
    Task<IEnumerable<Category>> GetByKeyword(string keyword);
    Task<Category> Create(CategoryDTO categoryDTO);
    Task Update(int id, CategoryDTO categoryDTO);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}
