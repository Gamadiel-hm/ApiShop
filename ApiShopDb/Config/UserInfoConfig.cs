using ApiShopModel.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiShopDb.Config
{
    public class UserInfoConfig : IEntityTypeConfiguration<UserInfo>
    {
        public void Configure(EntityTypeBuilder<UserInfo> builder)
        {
            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasMaxLength(40);
            builder.Property(prop => prop.LastName)
                .IsRequired()
                .HasMaxLength(60);
            builder.HasIndex(index => index.Email)
                .IsUnique();
            builder.Property(prop => prop.Email)
                .IsRequired()
                .HasMaxLength(150);
            builder.Property(prop => prop.Age)
                .IsRequired();
            builder.Property(prop => prop.Genre)
                .IsRequired();
            builder.Property(prop => prop.Password)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(prop => prop.UserInfoId)
                .HasDefaultValueSql("NEWID()");
        }
    }
}
