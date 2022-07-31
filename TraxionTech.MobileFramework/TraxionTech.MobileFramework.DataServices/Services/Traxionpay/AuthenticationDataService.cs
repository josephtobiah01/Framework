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
using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Authentication;
using TraxionTech.MobileFramework.Models.Traxionpay.Authentication;

namespace TraxionTech.MobileFramework.DataServices.Services.Traxionpay
{
    public class AuthenticationDataService : IAuthenticationDataService
    {
        public async Task<AuthenticateUserResponse> PostAuthenticatePersonAsync(AuthenticateUserRequest payload)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var Data = await client.PostAsJsonAsync(TraxionPayEndpoints.AuthenticateUser, payload);

                var JSONData = await Data.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<AuthenticateUserResponse>(JSONData);

                return data;
            }
        }

        public async Task<LoginResponse> PostLoginAsync(LoginRequest payload)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var Data = await client.PostAsJsonAsync(TraxionPayEndpoints.Login, payload);

                var JSONData = await Data.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<LoginResponse>(JSONData);

                return data;
            }
        }

        public async Task<LoginResponse> PostLoginPinCodeAsync(LoginPinCodeRequest payload)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var Data = await client.PostAsJsonAsync(TraxionPayEndpoints.LoginPinCode, payload);

                var JSONData = await Data.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<LoginResponse>(JSONData);

                return data;
            }
        }

        public async Task<LogoutResponse> PostLogOutAsync(string AccessToken)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

                var Data = await client.PostAsJsonAsync(TraxionPayEndpoints.Logout, new { });

                var JSONData = await Data.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<LogoutResponse>(JSONData);

                return data;
            }
        }

        public async Task<UpdatePasswordStageResponse> PostUpdatePasswordStageAsync(UpdatePasswordStageRequest payload)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var Data = await client.PostAsJsonAsync(TraxionPayEndpoints.UpdatePasswordStage, payload);

                var JSONData = await Data.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<UpdatePasswordStageResponse>(JSONData);

                return data;
            }
        }

        public async Task<UpdatePasswordResponse> PostUpdatePasswordAsync(UpdatePasswordRequest payload)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var Data = await client.PostAsJsonAsync(TraxionPayEndpoints.UpdatePassword, payload);

                var JSONData = await Data.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<UpdatePasswordResponse>(JSONData);

                return data;
            }
        }

        public async Task<UpdatePinCodeStageResponse> PostUpdatePinCodeStageAsync(UpdatePinCodeStageRequest payload)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var Data = await client.PostAsJsonAsync(TraxionPayEndpoints.UpdatePinCodeStage, payload);

                var JSONData = await Data.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<UpdatePinCodeStageResponse>(JSONData);

                return data;
            }
        }

        public async Task<UpdatePinCodeResponse> PostUpdatePinCodeAsync(UpdatePinCodeRequest payload)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var Data = await client.PostAsJsonAsync(TraxionPayEndpoints.UpdatePinCode, payload);

                var JSONData = await Data.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<UpdatePinCodeResponse>(JSONData);

                return data;
            }
        }

        public async Task<RefreshTokenResponse> PostRefreshTokenAsync(RefreshTokenRequest payload)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var Data = await client.PostAsJsonAsync(TraxionPayEndpoints.RefreshToken, payload);

                var JSONData = await Data.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<RefreshTokenResponse>(JSONData);

                return data;
            }
        }

        public async Task<ValidateRefreshTokenResponse> PostValidateRefreshTokenAsync(ValidateRefreshTokenRequest payload)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var Data = await client.PostAsJsonAsync(TraxionPayEndpoints.ValidateRefreshToken, payload);

                var JSONData = await Data.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<ValidateRefreshTokenResponse>(JSONData);

                return data;
            }
        }
    }
}
