#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

namespace TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Authentication
{
    public class AuthenticateUserResponseRoleAccess
    {
        public int MenuID { get; set; }
        public string URL { get; set; }
        public int Permission { get; set; }
    }
}
