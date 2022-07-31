#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

namespace TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Person
{
    public class GetPersonProfileResponsePersonIdentificationCard
    {
        public object personIdentificationId { get; set; }
        public object identificationId { get; set; }
        public string identicationCard { get; set; }
        public string identificationNumber { get; set; }
        public string photos { get; set; }
    }
}
