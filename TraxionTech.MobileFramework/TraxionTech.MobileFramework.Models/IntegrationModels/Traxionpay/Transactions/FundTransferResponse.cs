#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Base;

namespace TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Transactions
{
    public class FundTransferResponse : BaseResponse
    {
        public FundTransferResponseData data { get; set; }
    }
}
