#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System.Threading.Tasks;
using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Transactions;

namespace TraxionTech.MobileFramework.DataServices.Interfaces.Traxionpay
{
    public interface ITransactionDataService
    {
        Task<FundTransferResponse> PostFundTransferAsync(FundTransferRequest payload, string AccessToken);
        Task<BillerCategoryResponse> GetBillerCategoryAsync(string AccessToken);
        Task<BillersByCategoryResponse> GetBillersByCategoryAsync(int Id, string AccessToken);
    }
}
