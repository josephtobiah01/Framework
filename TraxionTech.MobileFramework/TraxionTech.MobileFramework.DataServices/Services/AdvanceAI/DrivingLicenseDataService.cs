#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using Newtonsoft.Json;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TraxionTech.MobileFramework.DataServices.Constants;
using TraxionTech.MobileFramework.DataServices.Interfaces.AdvanceAI;
using TraxionTech.MobileFramework.Models.IntegrationModels.AdvanceAI;

namespace TraxionTech.MobileFramework.DataServices.Services.AdvanceAI
{
    public class DrivingLicenseDataService : IDrivingLicenseDataService
    {
        public async Task<DrivingLicenseResponse> PostOCRLiteAsync(Stream ocrImage, string cardType)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-ADVAI-KEY", "42d722af2feaaf85");
            
            var content = new MultipartFormDataContent();
            var imageContent = new StreamContent(ocrImage);

            imageContent.Headers.ContentType = new MediaTypeHeaderValue("image/png");

            content.Add(imageContent, "ocrImage", "sampleFilename");
            content.Add(new StringContent(cardType), "cardType");

            var Data = await client.PostAsync(AAIEndpoints.OCRLite, content);

            var JSONData = await Data.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<DrivingLicenseResponse>(JSONData);

            return data;
        }
    }
}
