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
using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Authentication;
using TraxionTech.MobileFramework.Models.Traxionpay.Authentication;

namespace TraxionTech.MobileFramework.BusinessControllers.Traxionpay
{
    public class AuthenticationController : IAuthenticationController
    {
        private readonly IAuthenticationDataService _authenticationDataService;
        private readonly ISessionController _sessionController;
        public AuthenticationController(IAuthenticationDataService authenticationDataService, ISessionController sessionController)
        {
            _authenticationDataService = authenticationDataService ?? throw new ArgumentNullException(nameof(authenticationDataService));
            _sessionController = sessionController ?? throw new ArgumentNullException(nameof(sessionController));
        }

        public async Task<AuthenticationDetails> AuthenticatePersonAsync(
            string pinCode,
            string pinCodeConfirm,
            string password,
            string passwordConfirm,
            string PersonCode)
        {
            var payload = new AuthenticateUserRequest()
            {
                personCode = PersonCode,
                pinCode = pinCode,
                pinCodeConfirm = pinCodeConfirm,
                password = password,
                passwordConfirm = passwordConfirm
            };

            var result = await _authenticationDataService.PostAuthenticatePersonAsync(payload);

            var data = new AuthenticationDetails()
            {
                StatusCode = result.statusCode,
                Message = result.message,
                AccessToken = result.data == null ? "" : result.data.accessToken,
                UserCode = result.data == null ? "" : result.data.userCode
            };

            return data;
        }

        public async Task<AuthenticationDetails> LoginAsync(
            string username,
            string password,
            int applicationId,
            string location)
        {
            var payload = new LoginRequest()
            {
                username = username,
                password = password,
                applicationId = applicationId,
                location = location
            };

            var result = await _authenticationDataService.PostLoginAsync(payload);

            if (result.data == null)
                return new AuthenticationDetails() { StatusCode = result.statusCode, Message = result.message };

            _sessionController.SecretKey = result.data.secretKey;
            _sessionController.UserCode = result.data.userCode;
            _sessionController.PersonCode = result.data.personCode;
            _sessionController.AccessToken = result.data.accessToken;
            _sessionController.RefreshToken = result.data.refreshToken;

            var data = new AuthenticationDetails()
            {
                StatusCode = result.statusCode,
                Message = result.message
            };

            return data;
        }
        public async Task<AuthenticationDetails> LoginPinCodeAsync(
            string username,
            string password,
            int applicationId,
            string location,
            string refreshToken)
        {
            var payload = new LoginPinCodeRequest()
            {
                username = username,
                password = password,
                applicationId = applicationId,
                location = location,
                refreshToken = refreshToken
            };

            var result = await _authenticationDataService.PostLoginPinCodeAsync(payload);

            if (result.data == null)
                return new AuthenticationDetails() { StatusCode = result.statusCode, Message = result.message };

            _sessionController.SecretKey = result.data.secretKey;
            _sessionController.UserCode = result.data.userCode;
            _sessionController.PersonCode = result.data.personCode;
            _sessionController.AccessToken = result.data.accessToken;
            _sessionController.RefreshToken = result.data.refreshToken;

            var data = new AuthenticationDetails()
            {
                StatusCode = result.statusCode,
                Message = result.message
            };

            return data;
        }

        public async Task<LogoutDetails> LogoutAsync(string AccessToken)
        {
            var result = await _authenticationDataService.PostLogOutAsync(AccessToken);

            var data = new LogoutDetails()
            {
                StatusCode = result.statusCode
            };
            return data;
        }

        public async Task<UpdatePasswordDetails> UpdatePasswordStageAsync(
            string newPassword,
            string newPasswordConfirm,
            string PersonCode,
            string UserCode)
        {
            var payload = new UpdatePasswordStageRequest()
            {
                personCode = PersonCode,
                userCode = UserCode,
                newPassword = newPassword,
                newPasswordConfirm = newPasswordConfirm
            };

            var result = await _authenticationDataService.PostUpdatePasswordStageAsync(payload);

            var data = new UpdatePasswordDetails()
            {
                StatusCode = result.statusCode,
                Message = result.message
            };

            return data;
        }

        public async Task<UpdatePasswordDetails> UpdatePasswordAsync(
            string otp,
            string PersonCode,
            string UserCode)
        {
            var payload = new UpdatePasswordRequest()
            {
                personCode = PersonCode,
                userCode = UserCode,
                otp = otp
            };

            var result = await _authenticationDataService.PostUpdatePasswordAsync(payload);

            var data = new UpdatePasswordDetails()
            {
                StatusCode = result.statusCode,
                Message = result.message
            };

            return data;
        }

        public async Task<UpdatePinCodeDetails> UpdatePinCodeStageAsync(
            string newPinCode,
            string newPinCodeConfirm,
            string PersonCode,
            string UserCode)
        {
            var payload = new UpdatePinCodeStageRequest()
            {
                personCode = PersonCode,
                userCode = UserCode,
                newPinCode = newPinCode,
                newPinCodeConfirm = newPinCodeConfirm
            };

            var result = await _authenticationDataService.PostUpdatePinCodeStageAsync(payload);

            var data = new UpdatePinCodeDetails()
            {
                StatusCode = result.statusCode,
                Message = result.message
            };

            return data;
        }

        public async Task<UpdatePinCodeDetails> UpdatePinCodeAsync(
            string otp,
            string PersonCode,
            string UserCode)
        {
            var payload = new UpdatePinCodeRequest()
            {
                personCode = PersonCode,
                userCode = UserCode,
                otp = otp
            };

            var result = await _authenticationDataService.PostUpdatePinCodeAsync(payload);

            var data = new UpdatePinCodeDetails()
            {
                StatusCode = result.statusCode,
                Message = result.message
            };

            return data;
        }

        public async Task<RefreshTokenDetails> RefreshTokenAsync(string refreshToken)
        {
            var payload = new RefreshTokenRequest()
            {
                refreshToken = refreshToken
            };

            var result = await _authenticationDataService.PostRefreshTokenAsync(payload);

            var data = new RefreshTokenDetails()
            {
                StatusCode = result.statusCode,
                Message = result.message,
                RefreshToken = result.data == null ? "" : result.data.refreshToken
            };

            return data;
        }

        public async Task<ValidateRefreshTokenDetails> ValidateRefreshTokenAsync(string refreshToken)
        {
            var payload = new ValidateRefreshTokenRequest()
            {
                refreshToken = refreshToken
            };

            var result = await _authenticationDataService.PostValidateRefreshTokenAsync(payload);

            var data = new ValidateRefreshTokenDetails()
            {
                StatusCode = result.statusCode
            };

            return data;
        }
    }
}
