using System.Collections.Generic;

namespace TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Users
{
    public class TransactionsResponseData
    {
        public List<TransactionsResponseItem> transactions { get; set; }
        public int max { get; set; }
    }
}
