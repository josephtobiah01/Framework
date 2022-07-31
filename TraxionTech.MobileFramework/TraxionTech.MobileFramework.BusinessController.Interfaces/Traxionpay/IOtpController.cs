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
    public interface IOtpController
    {
        Task<OtpDetails> ResendOtpAsync(string id, string mobileNumber);
    }
}
