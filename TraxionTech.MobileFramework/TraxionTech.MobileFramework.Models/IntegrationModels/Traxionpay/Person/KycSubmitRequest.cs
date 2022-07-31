#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

namespace TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Person
{
    public class KycSubmitRequest
    {
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string suffix { get; set; }
        public string birthPlace { get; set; }
        public string birthDate { get; set; }
        public int gender { get; set; }
        public int civilStatus { get; set; }
        public string mobileNumber { get; set; }
        public int emailId { get; set; }
        public string email { get; set; }
        public string nationality { get; set; }
        public int addressId { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public int cityId { get; set; }
        public string zipCode { get; set; }
        public int sourceOfIncome { get; set; }
        public int natureOfWork { get; set; }
        public int identificationId { get; set; }
        public string identificationNumber { get; set; }
        public string identificationFront { get; set; }
        public string identificationBack { get; set; }
        public string selfie { get; set; }
    }
}
