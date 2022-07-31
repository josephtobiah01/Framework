#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System.Threading.Tasks;
using TraxionTech.MobileFramework.Models.BusinessModels;

namespace TraxionTech.MobileFramework.BusinessControllers.Interfaces.Traxionpay
{
    public interface IHelpersController
    {
        Task<RegionDetails> GetRegionsAsync();
        Task<ProvinceDetails> GetProvinceAsync(int Id);
        Task<CitiesDetails> GetCitiesAsync(int Id);
        Task<SourceOfIncomeDetails> GetSourceOfIncomeAsync();
        Task<NatureOfWorkDetails> GetNatureOfWorkAsync();
        Task<IdentificationsDetails> GetIdentificationAsync();
    }
}
