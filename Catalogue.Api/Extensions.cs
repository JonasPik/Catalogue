using Catalogue.Api.Dtos;
using Catalogue.Api.Entities;

namespace Catalogue.Api
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item)
        {
            var dto = new ItemDto
            {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                Price = item.Price,
                CreatedDate = item.CreatedDate
            };

            return dto;
        }
    }
}