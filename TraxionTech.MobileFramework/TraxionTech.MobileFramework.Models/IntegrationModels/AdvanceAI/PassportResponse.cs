#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

namespace TraxionTech.MobileFramework.Models.IntegrationModels.AdvanceAI
{
    public class PassportResponse
    {
        public string code { get; set; }
        public string message { get; set; }
        public PassportResponseData data { get; set; }
        public object extra { get; set; }
        public string transactionId { get; set; }
        public string pricingStrategy { get; set; }
    }
}
