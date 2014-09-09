using eCommerceSoa.BusinessLayer.Contract;
using eCommerceSoa.DataAccess.Contract;
using eCommerceSoa.Domain.Master.Login;

namespace eCommerceSoa.Business
{
    public class LoginService : ILoginService
    {
        private readonly IRepository<Login> _loginRepository;

        public LoginService(IRepository<Login> loginRepository)
        {
            _loginRepository = loginRepository;
        }

        //validation annotation goes here
        //transaction annotation goes here
        public void AddLogin(Login login)
        {
            _loginRepository.Create(login);
        }

        //validation annotation goes here
        //transaction annotation goes here
        public void ChangePassword(ChangePassword password)
        {
            if (password.NewPassword.ToLower().Equals(password.Login.Password.ToLower()))
                throw new System.Exception("");

            password.Login.Password = password.NewPassword;

            _loginRepository.Update(password.Login);
        }

        //validation annotation goes here
        //transaction annotation goes here
        public void Activate(Login login)
        {
            login.Active = true;
            _loginRepository.Update(login);
        }

        //validation annotation goes here
        //transaction annotation goes here
        public void Deactivate(Login login)
        {
            login.Active = false;
            _loginRepository.Update(login);
        }
    }
}
