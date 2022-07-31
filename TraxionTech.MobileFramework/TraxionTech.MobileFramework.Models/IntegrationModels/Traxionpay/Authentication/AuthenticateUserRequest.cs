#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

namespace TraxionTech.MobileFramework.Models.Traxionpay.Authentication
{
    public class AuthenticateUserRequest
    {
        public string personCode { get; set; }
        public string pinCode { get; set; }
        public string pinCodeConfirm { get; set; }
        public string password { get; set; }
        public string passwordConfirm { get; set; }
    }
}
