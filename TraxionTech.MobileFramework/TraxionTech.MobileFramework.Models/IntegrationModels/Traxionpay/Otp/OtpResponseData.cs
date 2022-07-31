#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

namespace TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Otp
{
    public class OtpResponseData
    {
        public string personCode { get; set; }
        public string userCode { get; set; }
        public string otpCode { get; set; }
    }
}
