#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System.Threading.Tasks;
using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Person;
using TraxionTech.MobileFramework.Models.Traxionpay.Person;

namespace TraxionTech.MobileFramework.DataServices.Interfaces.Traxionpay
{
    public interface IPersonDataService
    {
        Task<CreatePersonResponse> PostCreatePersonAsync(CreatePersonRequest payload);
        Task<ValidatePersonResponse> PostValidatePersonAsync(ValidatePersonRequest payload);
        Task<RegisterPersonResponse> PostRegisterPersonAsync(RegisterPersonRequest payload, string AccessToken);
        Task<GetPersonProfileResponse> PostGetProfileAsync(string AccessToken);
        Task<KycSubmitResponse> PostKYCAsync(string AccessToken, KycSubmitRequest payload);
    }
}
