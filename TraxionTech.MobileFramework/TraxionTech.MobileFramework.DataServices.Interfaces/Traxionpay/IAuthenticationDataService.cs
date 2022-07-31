#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System.Threading.Tasks;
using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Authentication;
using TraxionTech.MobileFramework.Models.Traxionpay.Authentication;

namespace TraxionTech.MobileFramework.DataServices.Interfaces.Traxionpay
{
    public interface IAuthenticationDataService
    {
        Task<AuthenticateUserResponse> PostAuthenticatePersonAsync(AuthenticateUserRequest payload);
        Task<LoginResponse> PostLoginAsync(LoginRequest payload);
        Task<LoginResponse> PostLoginPinCodeAsync(LoginPinCodeRequest payload);
        Task<LogoutResponse> PostLogOutAsync(string AccessToken);
        Task<UpdatePasswordStageResponse> PostUpdatePasswordStageAsync(UpdatePasswordStageRequest payload);
        Task<UpdatePasswordResponse> PostUpdatePasswordAsync(UpdatePasswordRequest payload);
        Task<UpdatePinCodeStageResponse> PostUpdatePinCodeStageAsync(UpdatePinCodeStageRequest payload);
        Task<UpdatePinCodeResponse> PostUpdatePinCodeAsync(UpdatePinCodeRequest payload);
        Task<RefreshTokenResponse> PostRefreshTokenAsync(RefreshTokenRequest payload);
        Task<ValidateRefreshTokenResponse> PostValidateRefreshTokenAsync(ValidateRefreshTokenRequest payload);
    }
}
