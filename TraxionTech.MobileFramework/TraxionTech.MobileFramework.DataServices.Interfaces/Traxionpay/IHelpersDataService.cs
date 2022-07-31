#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System.Threading.Tasks;
using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Helpers;

namespace TraxionTech.MobileFramework.DataServices.Interfaces.Traxionpay
{
    public interface IHelpersDataService
    {
        Task<RegionsResponse> GetRegionsAsync();
        Task<ProvinceResponse> GetProvinceAsync(int Id);
        Task<CitiesResponse> GetCititesAsync(int Id);
        Task<SourceOfIncomeResponse> GetSourceOfIncomeAsync();
        Task<NatureOfWorkResponse> GetNatureOfWorkAsync();
        Task<IdentificationsResponse> GetIdentificationAsync();
    }
}
