using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entities;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            //Names are given as a parameter for constructor method
            builder.HasData(
            new Product("Dotring")
            {
                Id = 1,
                CategoryId = 1,
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now
            },
            new Product("Cabel Fastel")
            {
                Id = 2,
                CategoryId = 1,
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now
            }, new Product("Farker")
            {
                Id = 3,
                CategoryId = 1,
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now
            }, new Product("The Origin Of Species")
            {
                Id = 4,
                CategoryId = 2,
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now
            }, new Product("Gone with the Wind")
            {
                Id = 5,
                CategoryId = 2,
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now
            }, new Product("Killing the Mockingbird")
            {
                Id = 6,
                CategoryId = 2,
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now
            }
            );
        }
    }
}
