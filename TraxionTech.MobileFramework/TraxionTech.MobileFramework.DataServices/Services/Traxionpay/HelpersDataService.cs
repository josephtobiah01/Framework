#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TraxionTech.MobileFramework.DataServices.Endpoints;
using TraxionTech.MobileFramework.DataServices.Interfaces.Traxionpay;
using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Helpers;

namespace TraxionTech.MobileFramework.DataServices.Services.Traxionpay
{
    public class HelpersDataService : IHelpersDataService
    {
        public async Task<RegionsResponse> GetRegionsAsync()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", string.Empty);

                var x = await client.GetFromJsonAsync<RegionsResponse>(TraxionPayEndpoints.Regions);
                return x;

            }
        }

        public async Task<ProvinceResponse> GetProvinceAsync(int Id)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var x = TraxionPayEndpoints.Regions + Id + TraxionPayEndpoints.Province;
                var res =  await client.GetFromJsonAsync<ProvinceResponse>(TraxionPayEndpoints.Regions + Id + TraxionPayEndpoints.Province);
                return res;
            }
        }

        public async Task<CitiesResponse> GetCititesAsync(int Id)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var x = TraxionPayEndpoints.Helpers +
                    TraxionPayEndpoints.Province +
                    Id +
                    TraxionPayEndpoints.Cities;
                return await client.GetFromJsonAsync<CitiesResponse>(
                    TraxionPayEndpoints.Helpers +
                    TraxionPayEndpoints.Province +
                    Id + 
                    TraxionPayEndpoints.Cities);

            }
        }

        public async Task<SourceOfIncomeResponse> GetSourceOfIncomeAsync()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", string.Empty);

                return await client.GetFromJsonAsync<SourceOfIncomeResponse>(TraxionPayEndpoints.SourceOfIncome);
            }
        }

        public async Task<NatureOfWorkResponse> GetNatureOfWorkAsync()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", string.Empty);

                return await client.GetFromJsonAsync<NatureOfWorkResponse>(TraxionPayEndpoints.NatureOfWork);
            }
        }

        public async Task<IdentificationsResponse> GetIdentificationAsync()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", string.Empty);

                return await client.GetFromJsonAsync<IdentificationsResponse>(TraxionPayEndpoints.Identifications);
            }
        }
    }
}
