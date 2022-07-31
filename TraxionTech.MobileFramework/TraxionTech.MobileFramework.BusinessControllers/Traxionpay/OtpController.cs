#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System;
using System.Threading.Tasks;
using TraxionTech.MobileFramework.BusinessControllers.Interfaces.Traxionpay;
using TraxionTech.MobileFramework.DataServices.Interfaces.Traxionpay;
using TraxionTech.MobileFramework.Models.BusinessModels;
using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Otp;

namespace TraxionTech.MobileFramework.BusinessControllers.Traxionpay
{
    public class OtpController : IOtpController
    {
        private readonly IOtpDataService _otpDataService;
        private readonly ISessionController _sessionController;

        public OtpController(IOtpDataService otpDataService, ISessionController sessionController)
        {
            _otpDataService = otpDataService ?? throw new ArgumentNullException(nameof(otpDataService));
            _sessionController = sessionController ?? throw new ArgumentNullException(nameof(sessionController));
        }

        public async Task<OtpDetails> ResendOtpAsync(string id, string mobileNumber)
        {
            var payload = new OtpRequest()
            {
                contactOptionId = id,
                contactOptionValue = mobileNumber
            };

            var result = await _otpDataService.PostResendOtpAsync(payload);

            var data = new OtpDetails()
            {
                PersonCode = result.data == null ? "" : result.data.personCode,
                UserCode = result.data == null ? "" : result.data.userCode,
                StatusCode = result.statusCode,
                Message = result.message
            };

            _sessionController.PersonCode = result.data == null ? "" : result.data.personCode;
            _sessionController.UserCode = result.data == null ? "" : result.data.userCode;
            return data;
        }
    }
}
