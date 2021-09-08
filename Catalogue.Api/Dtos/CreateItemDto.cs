using System.ComponentModel.DataAnnotations;

namespace Catalogue.Api.Dtos
{
    public class CreateItemDto
    {
        [Required]
        public string Name { get; init; }
        public string Description { get; init; }
        [Required]
        [Range(1, 1000)]
        public decimal Price { get; init; }
    }
}