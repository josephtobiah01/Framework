#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System.Collections.Generic;

namespace TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Authentication
{
    public class LoginResponseData
    {
        public string userCode { get; set; }
        public string secretKey { get; set; }
        public string personCode { get; set; }
        public string walletCode { get; set; }
        public object merchantCode { get; set; }
        public int roleId { get; set; }
        public int applicationId { get; set; }
        public List<LoginResponseRoleAccess> roleAccess { get; set; }
        public string accessToken { get; set; }
        public string refreshToken { get; set; }
    }
}
