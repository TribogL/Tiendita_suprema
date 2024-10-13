

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tiendita_suprema.Models;

[Table("Categories")]
public class Category
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [MaxLength(250)]
    public string Name { get; set; }

    [Column("description")]
    [MaxLength(500)]
    public string? Description { get; set; }

    public Category(string name, string? description = null)
    {
        Name = name.ToLower().Trim();
        Description = description?.ToLower().Trim();
    }
    public Category()
    {
    }
}
