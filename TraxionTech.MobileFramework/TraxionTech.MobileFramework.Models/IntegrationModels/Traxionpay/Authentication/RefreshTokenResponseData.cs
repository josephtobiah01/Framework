#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

namespace TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Authentication
{
    public class RefreshTokenResponseData
    {
        public string accessToken { get; set; }
        public string refreshToken { get; set; }
    }
}
