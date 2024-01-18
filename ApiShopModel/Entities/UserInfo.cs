using ApiShopModel.Entities.Enums;

namespace ApiShopModel.Entities
{
    public class UserInfo
    {
        public Guid UserInfoId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public GenreEnum Genre { get; set; }
        public List<UserInfoUserRol> UserInfoUserRols { get; set; }
    }
}
