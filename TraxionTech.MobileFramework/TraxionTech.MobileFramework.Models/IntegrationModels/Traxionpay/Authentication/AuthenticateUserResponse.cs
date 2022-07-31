#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Base;

namespace TraxionTech.MobileFramework.Models.Traxionpay.Authentication
{
    public class AuthenticateUserResponse : BaseResponse
    {
        public AuthenticateUserResponseData data { get; set; }
    }
}
