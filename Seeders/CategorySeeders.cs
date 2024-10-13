

using Bogus;
using Microsoft.EntityFrameworkCore;
using Tiendita_suprema.Models;

namespace Tiendita_suprema.Seeders;
public class CategorySeeders
    {
        public static void Seed(ModelBuilder modelBuilder)
{
    var categories = GenerateCategories(10);
    modelBuilder.Entity<Category>().HasData(categories);
}

public static IEnumerable<Category> GenerateCategories(int count)
{
    var faker = new Faker<Category>()
        .RuleFor(a => a.Id, f => f.IndexFaker + 1)
        .RuleFor(a => a.Name, f => f.Person.FirstName)
        .RuleFor(a => a.Description, f => f.Commerce.ProductDescription());
    return faker.Generate(count);
}
    }
