using eCommerceSoa.Domain.Master.Login;

namespace eCommerceSoa.BusinessLayer.Contract
{
    public interface ILoginService
    {
        void AddLogin(Login login);
        void ChangePassword(ChangePassword password);
        void Activate(Login login);
        void Deactivate(Login login);
    }
}