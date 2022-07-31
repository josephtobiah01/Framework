#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TraxionTech.MobileFramework.BusinessControllers.Interfaces.Traxionpay;
using TraxionTech.MobileFramework.DataServices.Interfaces.Traxionpay;
using TraxionTech.MobileFramework.Models.BusinessModels;
using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Transactions;

namespace TraxionTech.MobileFramework.BusinessControllers.Traxionpay
{
    public class TransactionController : ITransactionController
    {
        private readonly ITransactionDataService _transactionDataService;
        public TransactionController(ITransactionDataService transactionDataService)
        {
            _transactionDataService = transactionDataService ?? throw new ArgumentNullException(nameof(transactionDataService));
        }

        public async Task<TransactionDetails> FundTransferAsync(int tenderId, List<FundTransferDetailsRequest> transactionDetails, string AccessToken)
        {
            var payload = new FundTransferRequest()
            {
                tenderId = tenderId,
                transactionDetails = transactionDetails
            };

            var result = await _transactionDataService.PostFundTransferAsync(payload, AccessToken);

            if (result.data == null)
                return new TransactionDetails() { StatusCode = result.statusCode, Message = result.message };

            var data = new TransactionDetails()
            {
                StatusCode = result.statusCode,
                Message = result.message,
                MobileNumber = result.data.mobileNumber,
                FirstName = result.data.firstName,
                LastName = result.data.lastName,
                Amount = result.data.amount,
            };

            return data;
        }

        public async Task<BillerDetails> BillerCategoryAsync(string AccessToken)
        {
            var result = await _transactionDataService.GetBillerCategoryAsync(AccessToken);

            var data = new BillerDetails()
            {
                StatusCode = result.statusCode,
                BillerCategories = result.data.billerCategories,
                Message = result.message
            };

            return data;
        }

        public async Task<BillersByCategoryDetails> BillersByCategoryAsync(int Id, string AccessToken)
        {
            var result = await _transactionDataService.GetBillersByCategoryAsync(Id, AccessToken);

            var data = new BillersByCategoryDetails()
            {
                StatusCode = result.statusCode,
                BillersByCategory = result.data.billersByCategory,
                Message = result.message
            };

            return data;
        }
    }
}
