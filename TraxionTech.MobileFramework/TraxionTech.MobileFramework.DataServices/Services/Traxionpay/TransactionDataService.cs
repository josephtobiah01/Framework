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
using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Transactions;

namespace TraxionTech.MobileFramework.DataServices.Services.Traxionpay
{
    public class TransactionDataService : ITransactionDataService
    {
        public async Task<FundTransferResponse> PostFundTransferAsync(FundTransferRequest payload, string AccessToken)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

                var Data = await client.PostAsJsonAsync(TraxionPayEndpoints.FundTransfer, payload);

                var JSONData = await Data.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<FundTransferResponse>(JSONData);

                return data;
            }
        }

        public async Task<BillerCategoryResponse> GetBillerCategoryAsync(string AccessToken)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

                var x = await client.GetFromJsonAsync<BillerCategoryResponse>(TraxionPayEndpoints.BillerCategory);
                return x;

            }
        }

        public async Task<BillersByCategoryResponse> GetBillersByCategoryAsync(int Id, string AccessToken)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

                var x = await client.GetFromJsonAsync<BillersByCategoryResponse>(TraxionPayEndpoints.BillerCategory + Id + TraxionPayEndpoints.BillersByCategory);
                return x;

            }
        }
    }
}
