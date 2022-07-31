#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System.Threading.Tasks;
using TraxionTech.MobileFramework.Models.BusinessModels;
using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Person;

namespace TraxionTech.MobileFramework.BusinessControllers.Interfaces.Traxionpay
{
    public interface IPersonController
    {
        Task<PersonDetails> RegisterUserAsync(string mobileNumber, int id);
        Task<ValidateDetails> ValidatePersonAsync(string personCode, string otpCode);
        Task<RegisterDetails> RegisterPersonAsync(
            string firstName,
            string lastName,
            string middleName,
            int gender,
            string birthDate,
            string address1,
            string address2,
            int cityId,
            string zipCode,
            int addressTypeId,
            string contactOptionId,
            string contactOptionValue,
            string AccessToken);

        Task<ProfileDetails> GetPersonProfileAsync(string AccessToken);
        Task<KycDetails> KYCAsync(string AccessToken, KycSubmitRequest payload);
    }
}
