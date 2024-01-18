using ApiShopModel.Entities.Enums;

namespace ApiShopModel.Entities
{
    public class UserSecurity
    {
        public Guid UserInfoId { get; set; }
        public int NumberAttempts { get; set; }
        public int CancelAccount { get; set; }
        public FailedRegisterEnum FailedRegister { get; set; }
        public UserInfo UserInfo { get; set; }
    }
}
