namespace ApiShopModel.Entities
{
    public class UserInfoUserRol
    {
        public int UserInfoId { get; set; }
        public int UserRolId { get; set; }
        public UserInfo UserInfo { get; set; }
        public UserRol UserRol { get; set; }
    }
}
