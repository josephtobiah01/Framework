#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

namespace TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Transactions
{
    public class FundTransferDetailsRequest
    {
        public string MobileNumber { get; set; }
        public double Amount { get; set; }
        public string Message { get; set; }
    }
}
