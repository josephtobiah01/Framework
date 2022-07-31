#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

namespace TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Authentication
{
    public class UpdatePinCodeRequest
    {
        public string userCode { get; set; }
        public string personCode { get; set; }
        public string otp { get; set; }
    }
}
