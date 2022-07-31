#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using TraxionTech.MobileFramework.Models.BusinessModels.Base;

namespace TraxionTech.MobileFramework.Models.BusinessModels
{
    public class PersonDetails : BaseResponseDetails
    {
        public string MobileNumber { get; set; }
        public string PersonCode { get; set; }
    }

    public class ValidateDetails : BaseResponseDetails
    {
        public bool Valid { get; set; }
    }

    public class KycDetails : BaseResponseDetails
    {
    }

    public class ProfileDetails : BaseResponseDetails
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string Birthdate { get; set; }
        public string Email { get; set; }
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
        public string Region { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
               
        public int IsApproved { get; set; }
        public int Gender { get; set; }
        public int RegionId { get; set; }
        public int ProvinceId { get; set; }
        public int CityId { get; set; }
        public int PersonContactId { get; set; }
        public int PersonAddressId { get; set; }
        public int PayBills { get; set; }
        public int ELoad { get; set; }
        public int QrCode { get; set; }
        public int CashIn { get; set; }
        public int SendMoney { get; set; }
        public int Insurance { get; set; }
        public int BankTransfer { get; set; }
    }
}
