using ApiShopModel.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiShopDb.Config
{
    public class UserSecurityConfig : IEntityTypeConfiguration<UserSecurity>
    {
        public void Configure(EntityTypeBuilder<UserSecurity> builder)
        {
            builder.Property(prop => prop.NumberAttempts)
                .HasDefaultValue(0);
            builder.Property(prop => prop.CancelAccount)
                .HasDefaultValue(0);

            builder.HasKey(prop => prop.UserInfoId);
            builder.HasOne(one => one.UserInfo)
                .WithOne()
                .HasForeignKey<UserInfo>(fk => fk.UserInfoId);
            
        }
    }
}
