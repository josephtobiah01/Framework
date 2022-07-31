#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System;
using System.IO;
using System.Threading.Tasks;
using TraxionTech.MobileFramework.BusinessControllers.Interfaces.AdvanceAI;
using TraxionTech.MobileFramework.DataServices.Interfaces.AdvanceAI;
using TraxionTech.MobileFramework.Models.BusinessModels.AdvanceAI;

namespace TraxionTech.MobileFramework.BusinessControllers.AdvanceAI
{
    public class OCRLiteController : IOCRLiteController
    {
        private readonly IDrivingLicenseDataService _drivingLicenseDataService;

        public OCRLiteController(IDrivingLicenseDataService drivingLicenseDataService)
        {
            _drivingLicenseDataService = drivingLicenseDataService ?? throw new ArgumentNullException(nameof(drivingLicenseDataService));
        }

        public async Task<DriverLicenseDetails> GetDrivingLicenseInfoAsync(Stream ocrImage, string cardType)
        {
            var result = await _drivingLicenseDataService.PostOCRLiteAsync(ocrImage, cardType);

            var data = new DriverLicenseDetails()
            {
                Code = result.code,
                IdNumber = result.data.result == null ? "" : result.data.result.idNumber,
                Nationality = result.data.result == null ? "" :result.data.result.nationality
            };
            return data;
        }

        public async Task<TinDetails> GetTinInfoAsync(Stream ocrImage, string cardType)
        {
            var result = await _drivingLicenseDataService.PostOCRLiteAsync(ocrImage, cardType);

            var data = new TinDetails()
            {
                Code = result.code,
                IdNumber = result.data.result == null ? "" : result.data.result.idNumber
            };
            return data;
        }

        public async Task<PassportDetails> GetPassportInfoAsync(Stream ocrImage, string cardType)
        {
            var result = await _drivingLicenseDataService.PostOCRLiteAsync(ocrImage, cardType);

            var data = new PassportDetails()
            {
                Code = result.code,
                IdNumber = result.data.result == null ? "" : result.data.result.idNumber,
                Nationality = result.data.result == null ? "" : result.data.result.nationality
            };
            return data;
        }

        public async Task<UMIDDetails> GetUMIDInfoAsync(Stream ocrImage, string cardType)
        {
            var result = await _drivingLicenseDataService.PostOCRLiteAsync(ocrImage, cardType);

            var data = new UMIDDetails()
            {
                Code = result.code,
                IdNumber = result.data.result == null ? "" : result.data.result.idNumber
            };
            return data;
        }
    }
}
