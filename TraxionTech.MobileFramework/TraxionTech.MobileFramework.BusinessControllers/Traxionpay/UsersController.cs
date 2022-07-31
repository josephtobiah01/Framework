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

namespace TraxionTech.MobileFramework.BusinessControllers.Traxionpay
{
    public class UsersController : IUsersController
    {
        private readonly IUsersDataService _usersDataService;
        public UsersController(IUsersDataService usersDataService)
        {
            _usersDataService = usersDataService ?? throw new ArgumentNullException(nameof(usersDataService));
        }

        public async Task<UsersDetails> GetWalletAsync(string AccessToken)
        {
            var result = await _usersDataService.PostGetWalletAsync(AccessToken);

            var data = new UsersDetails()
            {
                StatusCode = result.statusCode,
                CurrentBalance = result.data.currentBalance,
                AvailableBalance = result.data.availableBalance,
                Message = result.message
            };
            return data;
        }

        public async Task<TransactionsDetails> GetTransactionsAsync(string AccessToken, int page, int limit)
        {
            var result = await _usersDataService.GetTransactionsAsync(AccessToken, page, limit);

            var data = new TransactionsDetails()
            {
                StatusCode = result.statusCode,
                Transactions = result.data.transactions,
                Message = result.message
            };
            return data;
        }
    }
}
