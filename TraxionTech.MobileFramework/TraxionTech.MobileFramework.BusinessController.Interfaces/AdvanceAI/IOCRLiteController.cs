#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System.IO;
using System.Threading.Tasks;
using TraxionTech.MobileFramework.Models.BusinessModels.AdvanceAI;

namespace TraxionTech.MobileFramework.BusinessControllers.Interfaces.AdvanceAI
{
    public interface IOCRLiteController
    {
        Task<DriverLicenseDetails> GetDrivingLicenseInfoAsync(Stream ocrImage, string cardType);
        Task<TinDetails> GetTinInfoAsync(Stream ocrImage, string cardType);
        Task<PassportDetails> GetPassportInfoAsync(Stream ocrImage, string cardType);
        Task<UMIDDetails> GetUMIDInfoAsync(Stream ocrImage, string cardType);
    }
}
