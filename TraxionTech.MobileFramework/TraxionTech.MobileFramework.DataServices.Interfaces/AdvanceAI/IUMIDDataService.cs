#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System.IO;
using System.Threading.Tasks;
using TraxionTech.MobileFramework.Models.IntegrationModels.AdvanceAI;

namespace TraxionTech.MobileFramework.DataServices.Interfaces.AdvanceAI
{
    public interface IUMIDDataService
    {
        Task<UMIDResponse> PostOCRLiteAsync(Stream ocrImage, string cardType);
    }
}
