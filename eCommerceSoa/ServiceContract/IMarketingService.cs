using System.ServiceModel;

namespace eCommerceSoa.ServiceContract
{
    [ServiceContract]
    public interface IMarketingService
    {
        void CreateCampaign();
        void GetCampaign();
        void UpdateCampaign();
        void RemoveCampaign();
    }
}
