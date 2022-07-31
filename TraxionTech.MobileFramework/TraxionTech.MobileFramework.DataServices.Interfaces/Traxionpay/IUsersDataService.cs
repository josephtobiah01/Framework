#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System.Threading.Tasks;
using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Users;

namespace TraxionTech.MobileFramework.DataServices.Interfaces.Traxionpay
{
    public interface IUsersDataService
    {
        Task<GetWalletResponse> PostGetWalletAsync(string AccessToken);
        Task<TransactionsResponse> GetTransactionsAsync(string AccessToken, int page, int limit);
    }
}
