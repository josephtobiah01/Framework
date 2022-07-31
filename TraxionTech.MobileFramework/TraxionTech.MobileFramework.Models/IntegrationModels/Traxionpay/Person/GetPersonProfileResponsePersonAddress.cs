#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

namespace TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Person
{
    public class GetPersonProfileResponsePersonAddress
    {
        public int personAddressId { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public int cityId { get; set; }
        public string city { get; set; }
        public int regionId { get; set; }
        public string regionName { get; set; }
        public int provinceId { get; set; }
        public string province { get; set; }
        public string zipCode { get; set; }
        public int addressTypeId { get; set; }
        public int isPrimaryAddress { get; set; }

    }
}
