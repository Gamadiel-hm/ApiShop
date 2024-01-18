namespace ApiShopModel.Entities
{
    public class UserRol
    {
        public int UserRolId { get; set; }
        public string Name { get; set; }
        public List<UserInfoUserRol> UserInfoUserRols { get; set; }
    }
}
