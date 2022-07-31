using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Base;

namespace TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Users
{
    public class TransactionsResponse : BaseResponse
    {
        public TransactionsResponseData data { get; set; }
    }
}
