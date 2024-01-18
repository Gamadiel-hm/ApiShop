using ApiShopModel.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiShopDb.Config
{
    public class UserInfoUserRolConfig : IEntityTypeConfiguration<UserInfoUserRol>
    {
        public void Configure(EntityTypeBuilder<UserInfoUserRol> builder)
        {
            builder.HasKey(key => new { key.UserInfoId, key.UserRolId });

        }
    }
}
