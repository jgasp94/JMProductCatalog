using System.ComponentModel.DataAnnotations;

namespace JMProductCatalog.App.DTOs
{
    public class CategoryDTO
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage ="O nome é obrigatório")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
