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
    public interface IAuthenticationController
    {
        Task<AuthenticationDetails> AuthenticatePersonAsync(
            string pinCode,
            string pinCodeConfirm,
            string password,
            string passwordConfirm,
            string PersonCode);
        Task<AuthenticationDetails> LoginAsync(
            string username,
            string password,
            int applicationId,
            string location);
        Task<AuthenticationDetails> LoginPinCodeAsync(
            string username,
            string password,
            int applicationId,
            string location,
            string refreshToken);
        Task<LogoutDetails> LogoutAsync(string AccessToken);
        Task<UpdatePasswordDetails> UpdatePasswordStageAsync(
            string newPassword,
            string newPasswordConfirm,
            string PersonCode,
            string UserCode);

        Task<UpdatePasswordDetails> UpdatePasswordAsync(
            string otp,
            string PersonCode,
            string UserCode);
        Task<UpdatePinCodeDetails> UpdatePinCodeStageAsync(
            string newPinCode,
            string newPinCodeConfirm,
            string PersonCode,
            string UserCode);
        Task<UpdatePinCodeDetails> UpdatePinCodeAsync(
            string otp,
            string PersonCode,
            string UserCode);
        Task<RefreshTokenDetails> RefreshTokenAsync(string refreshToken);
        Task<ValidateRefreshTokenDetails> ValidateRefreshTokenAsync(string refreshToken);
    }
}
