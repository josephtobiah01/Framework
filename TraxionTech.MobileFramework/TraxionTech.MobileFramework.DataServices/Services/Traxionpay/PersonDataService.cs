#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TraxionTech.MobileFramework.DataServices.Endpoints;
using TraxionTech.MobileFramework.DataServices.Interfaces.Traxionpay;
using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Person;
using TraxionTech.MobileFramework.Models.Traxionpay.Person;

namespace TraxionTech.MobileFramework.DataServices.Services.Traxionpay
{
    public class PersonDataService : IPersonDataService
    {
        public async Task<CreatePersonResponse> PostCreatePersonAsync(CreatePersonRequest payload)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var Data = await client.PostAsJsonAsync(TraxionPayEndpoints.CreatePerson, payload);

                var JSONData = await Data.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<CreatePersonResponse>(JSONData);

                return data;
            }
        }

        public async Task<ValidatePersonResponse> PostValidatePersonAsync(ValidatePersonRequest payload)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var Data = await client.PostAsJsonAsync(TraxionPayEndpoints.ValidatePerson, payload);

                var JSONData = await Data.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<ValidatePersonResponse>(JSONData);

                return data;
            }
        }

        public async Task<RegisterPersonResponse> PostRegisterPersonAsync(RegisterPersonRequest payload, string AccessToken)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

                var Data = await client.PostAsJsonAsync(TraxionPayEndpoints.RegisterPerson, payload);

                var JSONData = await Data.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<RegisterPersonResponse>(JSONData);

                return data;
            }
        }

        public async Task<GetPersonProfileResponse> PostGetProfileAsync(string AccessToken)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

                    var Data = await client.PostAsJsonAsync(TraxionPayEndpoints.GetProfile, new { });

                    var JSONData = await Data.Content.ReadAsStringAsync();

                    var data = JsonConvert.DeserializeObject<GetPersonProfileResponse>(JSONData);

                    return data;
                }
            }
            catch (System.Exception e)
            {

                var x = e.Message;
                return null;
            }            
        }

        public async Task<KycSubmitResponse> PostKYCAsync(string AccessToken, KycSubmitRequest payload)
        {                
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

                var Data = await client.PostAsJsonAsync(TraxionPayEndpoints.KYC, payload);

                var JSONData = await Data.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<KycSubmitResponse>(JSONData);

                return data;
            }
        }
    }
}
