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
using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Otp;

namespace TraxionTech.MobileFramework.DataServices.Services.Traxionpay
{
    public class OtpDataService : IOtpDataService
    {
        public async Task<OtpResponse> PostResendOtpAsync(OtpRequest payload)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var Data = await client.PostAsJsonAsync(TraxionPayEndpoints.ResendOtp, payload);

                var JSONData = await Data.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<OtpResponse>(JSONData);

                return data;
            }
        }
    }
}
