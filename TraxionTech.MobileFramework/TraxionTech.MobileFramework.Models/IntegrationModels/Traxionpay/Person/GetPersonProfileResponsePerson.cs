#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System.Collections.Generic;

namespace TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Person
{
    public class GetPersonProfileResponsePerson
    {
        public string personCode { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string suffix { get; set; }
        public string birthPlace { get; set; }
        public int gender { get; set; }
        public int civilStatus { get; set; }
        public string birthDate { get; set; }
        public int isApproved { get; set; }
        public List<GetPersonProfileResponsePersonContactOption> contactOptions { get; set; }
        public List<GetPersonProfileResponsePersonAddress> addresses { get; set; }
        public List<GetPersonProfileResponsePersonIdentificationCard> identificationCards { get; set; }
        public List<GetPersonProfileResponsePersonNatureOfWork> natureOfWork { get; set; }
        public List<GetPersonProfileResponsePersonSourceOfIncome> sourceOfIncome { get; set; }
        public List<GetPersonProfileResponsePersonPermission> personPermission { get; set; }
    }
}
