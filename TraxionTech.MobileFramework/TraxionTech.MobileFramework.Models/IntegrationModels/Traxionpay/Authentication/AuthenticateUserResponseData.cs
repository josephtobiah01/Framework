#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System.Collections.Generic;
using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Authentication;

namespace TraxionTech.MobileFramework.Models.Traxionpay.Authentication
{
    public class AuthenticateUserResponseData
    {
        public string userCode { get; set; }
        public string personCode { get; set; }
        public string walletCode { get; set; }
        public object merchantCode { get; set; }
        public int roleId { get; set; }
        public List<AuthenticateUserResponseRoleAccess> roleAccess { get; set; }
        public string accessToken { get; set; }
        public string refreshToken { get; set; }
    }
}
