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
using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Users;

namespace TraxionTech.MobileFramework.DataServices.Services.Traxionpay
{
    public class UsersDataService : IUsersDataService
    {
        public async Task<GetWalletResponse> PostGetWalletAsync(string AccessToken)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

                var Data = await client.PostAsJsonAsync(TraxionPayEndpoints.GetWallet, new { });

                var JSONData = await Data.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<GetWalletResponse>(JSONData);

                return data;
            }
        }

        public async Task<TransactionsResponse> GetTransactionsAsync(string AccessToken, int page, int limit)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

                var data = await client.GetFromJsonAsync<TransactionsResponse>(TraxionPayEndpoints.GetTransactions + "page=" + page + "&limit=" + limit);

                return data;
            }
        }
    }
}
