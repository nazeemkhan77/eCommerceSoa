using eCommerceSoa.Domain.Master.Login;

namespace eCommerceSoa.BusinessLayer.Contract
{
    public class ChangePassword
    {
        public Login Login { get; set; }
        public string NewPassword { get; set; }
    }
}
