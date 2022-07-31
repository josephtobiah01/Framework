#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

namespace TraxionTech.MobileFramework.Models.Traxionpay.Person
{
    public class CreatePersonResponseData
    {
        public string personCode { get; set; }

        public string otpCode { get; set; }

        public string mobileNumber { get; set; }

        public int applicationId { get; set; }
    }
}
