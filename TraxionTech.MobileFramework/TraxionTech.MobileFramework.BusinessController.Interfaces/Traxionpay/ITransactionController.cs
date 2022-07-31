#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System.Collections.Generic;
using System.Threading.Tasks;
using TraxionTech.MobileFramework.Models.BusinessModels;
using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Transactions;

namespace TraxionTech.MobileFramework.BusinessControllers.Interfaces.Traxionpay
{
    public interface ITransactionController
    {
        Task<TransactionDetails> FundTransferAsync(int tenderId, List<FundTransferDetailsRequest> transactionDetails, string AccessToken);
        Task<BillerDetails> BillerCategoryAsync(string AccessToken);
        Task<BillersByCategoryDetails> BillersByCategoryAsync(int Id, string AccessToken);
    }
}
