#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

namespace TraxionTech.MobileFramework.Models.IntegrationModels.AdvanceAI
{
    public class PassportResponseResult
    {
        public string birthday { get; set; }
        public string surName { get; set; }
        public string gender { get; set; }
        public string givenName { get; set; }
        public string idNumber { get; set; }
        public string type { get; set; }
        public string expiryDate { get; set; }
        public string birthPlace { get; set; }
        public string issuingAuthority { get; set; }
        public string nationality { get; set; }
        public string countryCode { get; set; }
        public string middleName { get; set; }
        public string issueDate { get; set; }
    }
}
