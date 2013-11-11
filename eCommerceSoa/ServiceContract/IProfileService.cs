using System.ServiceModel;

namespace eCommerceSoa.ServiceContract
{
    [ServiceContract]
    public interface IProfileService
    {
        void CreateUserProfile();
        void UpdateUserProfile();
        void RemoveUserProfile();
        void GetUserProfile();
    }
}
