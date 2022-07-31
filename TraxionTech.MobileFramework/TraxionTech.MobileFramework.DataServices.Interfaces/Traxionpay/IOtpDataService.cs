#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System.Threading.Tasks;
using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Otp;

namespace TraxionTech.MobileFramework.DataServices.Interfaces.Traxionpay
{
    public interface IOtpDataService
    {
        Task<OtpResponse> PostResendOtpAsync(OtpRequest payload);
    }
}
