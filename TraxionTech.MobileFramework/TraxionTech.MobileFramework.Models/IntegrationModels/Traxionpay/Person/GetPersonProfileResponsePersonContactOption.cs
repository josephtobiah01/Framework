#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

namespace TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Person
{
    public class GetPersonProfileResponsePersonContactOption
    {
        public int personContactId { get; set; }
        public int contactOptionId { get; set; }
        public string personContactValue { get; set; }
        public int isActive { get; set; }
        public int isPrimary { get; set; }
    }
}
