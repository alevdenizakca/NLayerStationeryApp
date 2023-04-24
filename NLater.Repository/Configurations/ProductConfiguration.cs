using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entities;

namespace NLayer.Repository.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id); //no needed but...
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x=> x.Name).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Stock).IsRequired();
            builder.Property(x=>x.Price).IsRequired().HasColumnType("decimal(18,2)"); //################.## => total 18 number. 16 whole number, 2 decimal number
            builder.ToTable("Product"); //no needed.
            builder.HasOne(x=>x.Category).WithMany(x=>x.Products).HasForeignKey(x=>x.CategoryId); //no needed...
            

        }
    }
}
