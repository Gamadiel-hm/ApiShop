using ApiShopModel.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiShopDb.Config
{
    public class UserRolConfig : IEntityTypeConfiguration<UserRol>
    {
        public void Configure(EntityTypeBuilder<UserRol> builder)
        {
            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
