#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System;
using System.Threading.Tasks;
using TraxionTech.MobileFramework.BusinessControllers.Interfaces.Traxionpay;
using TraxionTech.MobileFramework.DataServices.Interfaces.Traxionpay;
using TraxionTech.MobileFramework.Models.BusinessModels;
using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Person;
using TraxionTech.MobileFramework.Models.Traxionpay.Person;

namespace TraxionTech.MobileFramework.BusinessControllers.Traxionpay
{
    public class PersonController : IPersonController
    {
        private readonly IPersonDataService _personDataService;
        private readonly ISessionController _sessionController;
        public PersonController(IPersonDataService personDataService, ISessionController sessionController)
        {
            _personDataService = personDataService ?? throw new ArgumentNullException(nameof(personDataService));
            _sessionController = sessionController ?? throw new ArgumentNullException(nameof(sessionController));
        }

        public async Task<PersonDetails> RegisterUserAsync(string mobileNumber, int id)
        {
            var payload = new CreatePersonRequest()
            {
                mobileNumber = mobileNumber,
                applicationId = id
            };

            var result = await _personDataService.PostCreatePersonAsync(payload);

            var data = new PersonDetails()
            {
                MobileNumber = result.data == null ? "" : result.data.mobileNumber,
                PersonCode = result.data == null ? "" : result.data.personCode,
                StatusCode = result.statusCode,
                Message = result.message
            }; 
            _sessionController.PersonCode = result.data == null ? "" : result.data.personCode;
            return data;
        }

        public async Task<ValidateDetails> ValidatePersonAsync(string personCode, string otpCode)
        {
            var payload = new ValidatePersonRequest()
            {
                personCode = personCode,
                otpCode = otpCode
            };

            var result = await _personDataService.PostValidatePersonAsync(payload);

            var data = new ValidateDetails()
            {
                Message = result.message,
                Valid = result.data == null ? false : result.data.valid,
                StatusCode = result.statusCode
            };
            return data;
        }

        public async Task<RegisterDetails> RegisterPersonAsync(
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
            string AccessToken)
        {
            var payload = new RegisterPersonRequest()
            {
                firstName = firstName,
                lastName = lastName,
                middleName = middleName,
                gender = gender,
                birthDate = birthDate,
                address1 = address1,
                address2 = address2,
                cityId = cityId,
                zipCode = zipCode,
                addressTypeId = addressTypeId,
                contactOptionId = contactOptionId,
                contactOptionValue = contactOptionValue
            };

            var result = await _personDataService.PostRegisterPersonAsync(payload, AccessToken);

            var data = new RegisterDetails()
            {
                StatusCode = result.statusCode,
                Message = result.message,
            };
            return data;
        }

        public async Task<ProfileDetails> GetPersonProfileAsync(string AccessToken)
        {
            var result = await _personDataService.PostGetProfileAsync(AccessToken);

            if (result.data == null)
                return new ProfileDetails() { StatusCode = result.statusCode, Message = result.message};

            _sessionController.IsApproved = result.data == null ? 0 : result.data.person[0].isApproved;

            var data = new ProfileDetails()
            {
                StatusCode = result.statusCode,
                FirstName = result.data.person[0].firstName,
                MiddleName = result.data.person[0].middleName,
                LastName = result.data.person[0].lastName,
                Birthdate = result.data.person[0].birthDate,
                Gender = result.data.person[0].gender,
                Email = result.data.person[0].contactOptions[2].personContactValue,
                AddressOne = result.data.person[0].addresses[0].address1,
                AddressTwo = result.data.person[0].addresses[0].address2,
                RegionId = result.data.person[0].addresses[0].regionId,
                ProvinceId = result.data.person[0].addresses[0].provinceId,
                CityId = result.data.person[0].addresses[0].cityId,
                MobileNumber = result.data.person[0].contactOptions[0].personContactValue,
                ZipCode = result.data.person[0].addresses[0].zipCode,
                IsApproved = result.data.person[0].isApproved,
                PersonContactId = result.data.person[0].contactOptions[2].personContactId,
                PersonAddressId = result.data.person[0].addresses[0].personAddressId,
                PayBills = result.data.person[0].personPermission[0].value,
                ELoad = result.data.person[0].personPermission[1].value,
                QrCode = result.data.person[0].personPermission[2].value,
                CashIn = result.data.person[0].personPermission[3].value,
                SendMoney = result.data.person[0].personPermission[4].value,
                Insurance = result.data.person[0].personPermission[5].value,
                BankTransfer = result.data.person[0].personPermission[6].value,
                Message = result.message,                
            };
            return data;
        }

        public async Task<KycDetails> KYCAsync(string AccessToken, KycSubmitRequest payload)
        {

            var result = await _personDataService.PostKYCAsync(AccessToken, payload);

            var data = new KycDetails()
            {
                Message = result.message,
                StatusCode = result.statusCode
            };
            return data;
        }
    }
}
