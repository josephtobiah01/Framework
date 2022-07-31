#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

namespace TraxionTech.MobileFramework.Models.Traxionpay.Person
{
    public class ValidatePersonRequest
    {
        public string personCode { get; set; }
        public string otpCode { get; set; }
    }
}
