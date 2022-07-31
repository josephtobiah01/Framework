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
using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Helpers;

namespace TraxionTech.MobileFramework.BusinessControllers.Traxionpay
{
    public class HelpersController : IHelpersController
    {
        private readonly IHelpersDataService _helpersDataService;
        public HelpersController(IHelpersDataService helpersDataService)
        {
            _helpersDataService = helpersDataService ?? throw new ArgumentNullException(nameof(helpersDataService));
        }

        public async Task<RegionDetails> GetRegionsAsync()
        {

            var result = await _helpersDataService.GetRegionsAsync();

            var data = new RegionDetails()
            {
                regions = result.data == null ? new List<RegionData>() : result.data.regions,
                StatusCode = result.statusCode,
            };

            return data;
        }

        public async Task<ProvinceDetails> GetProvinceAsync(int Id)
        {

            var result = await _helpersDataService.GetProvinceAsync(Id);

            var data = new ProvinceDetails()
            {
                Provinces = result.data == null ? new List<ProvinceData>() : result.data.provinces,
                StatusCode = result.statusCode,
            };

            return data;
        }

        public async Task<CitiesDetails> GetCitiesAsync(int Id)
        {

            var result = await _helpersDataService.GetCititesAsync(Id);

            var data = new CitiesDetails()
            {
                Cities = result.data == null ? new List<CitiesData>() : result.data.cities,
                StatusCode = result.statusCode,
            };

            return data;
        }

        public async Task<SourceOfIncomeDetails> GetSourceOfIncomeAsync()
        {

            var result = await _helpersDataService.GetSourceOfIncomeAsync();

            var data = new SourceOfIncomeDetails()
            {
                SourceOfIncome = result.data == null ? new List<SourceOfIncomeResponseDataItem>() : result.data.sourceOfIncome,
                StatusCode = result.statusCode,
            };

            return data;
        }

        public async Task<NatureOfWorkDetails> GetNatureOfWorkAsync()
        {

            var result = await _helpersDataService.GetNatureOfWorkAsync();

            var data = new NatureOfWorkDetails()
            {
                NatureOfWork = result.data == null ? new List<NatureOfWorkResponseDataItem>() : result.data.natureOfWork,
                StatusCode = result.statusCode,
            };

            return data;
        }

        public async Task<IdentificationsDetails> GetIdentificationAsync()
        {

            var result = await _helpersDataService.GetIdentificationAsync();

            var data = new IdentificationsDetails()
            {
                Identifications = result.data == null ? new List<IdentificationsResponseItem>() : result.data.identifications,
                StatusCode = result.statusCode,
            };

            return data;
        }
    }
}
