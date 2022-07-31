#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

#define Uat

namespace TraxionTech.MobileFramework.DataServices.Endpoints
{
    public class TraxionPayEndpoints
    {
#if DEBUG
        public const string BaseUrl = "https://devapi2.traxionpay.com";
#elif UAT
        public const string BaseUrl = "https://uatapi2.traxionpay.com";
#else
        public const string BaseUrl = "http://10.25.12.151:5000";
#endif
        //Person
        public const string CreatePerson = BaseUrl + "/api/v1/persons/create";
        public const string ValidatePerson = BaseUrl + "/api/v1/persons/validate";
        public const string RegisterPerson = BaseUrl + "/api/v1/persons/register";
        public const string GetProfile = BaseUrl + "/api/v1/persons/get-profile";
        public const string KYC = BaseUrl + "/api/v1/persons/kyc/submit";

        //Authentication
        public const string AuthenticateUser = BaseUrl + "/api/v1/auth/set-credentials";
        public const string Login = BaseUrl + "/api/v1/auth/login";
        public const string LoginPinCode = BaseUrl + "/api/v1/auth/login/pincode";
        public const string Logout = BaseUrl + "/api/v1/auth/logout";
        public const string UpdatePasswordStage = BaseUrl + "/api/v1/auth/update-password/stage";
        public const string UpdatePassword = BaseUrl + "/api/v1/auth/update-password";
        public const string UpdatePinCodeStage = BaseUrl + "/api/v1/auth/update-pincode/stage";
        public const string UpdatePinCode = BaseUrl + "/api/v1/auth/update-pincode";
        public const string RefreshToken = BaseUrl + "/api/v1/auth/refresh-token";
        public const string ValidateRefreshToken = BaseUrl + "/api/v1/auth/refresh-token/validate";

        //Helpers
        public const string Helpers = BaseUrl + "/api/v1/helpers";
        public const string Regions = Helpers + "/regions/";
        public const string Province = "/provinces/";
        public const string Cities = "/cities/";
        public const string SourceOfIncome = BaseUrl + "/api/v1/helpers/sources-of-income";
        public const string NatureOfWork = BaseUrl + "/api/v1/helpers/natures-of-work";
        public const string Identifications = BaseUrl + "/api/v1/helpers/identifications";

        //Otp
        public const string ResendOtp = BaseUrl + "/api/v1/otp/generate";

        //Users
        public const string GetWallet = BaseUrl + "/api/v1/users/get-wallet";
        public const string GetTransactions = BaseUrl + "/api/v1/users/transactions?";

        //Transactions
        public const string FundTransfer = BaseUrl + "/api/v1/transactions/funds/transfer";
        public const string BillerCategory = BaseUrl + "/api/v1/transactions/categories/";
        public const string BillersByCategory = "/billers";
    }
}
