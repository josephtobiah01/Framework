#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

namespace TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Authentication
{
    public class LoginRequest
    {
        public string username { get; set; }
        public string password { get; set; }
        public int applicationId { get; set; }
        public string location { get; set; }
    }
}
