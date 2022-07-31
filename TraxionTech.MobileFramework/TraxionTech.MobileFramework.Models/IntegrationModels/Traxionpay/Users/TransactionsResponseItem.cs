namespace TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Users
{
    public class TransactionsResponseItem
    {
        public double amount { get; set; }
        public string transactionReferenceNumber { get; set; }
        public string transactionCode { get; set; }
        public string transactionName { get; set; }
        public string transactionDate { get; set; }
        public int entryType { get; set; }
    }
}
