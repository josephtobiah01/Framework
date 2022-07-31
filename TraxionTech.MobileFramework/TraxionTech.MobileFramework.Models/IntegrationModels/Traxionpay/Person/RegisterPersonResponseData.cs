#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

namespace TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Person
{
    public class RegisterPersonResponseData
    {
        public string personCode { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public int gender { get; set; }
        public string birthDate { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public int cityId { get; set; }
        public string zipCode { get; set; }
        public int addressTypeId { get; set; }
        public string contactOptionId { get; set; }
        public string contactOptionValue { get; set; }

    }
}
