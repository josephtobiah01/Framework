#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using TraxionTech.MobileFramework.Models.BusinessModels.Base;

namespace TraxionTech.MobileFramework.Models.BusinessModels
{
    public class AuthenticationDetails : BaseResponseDetails
    {
        public string AccessToken { get; set; }
        public string UserCode { get; set; }
    }

    public class LogoutDetails : BaseResponseDetails
    {
    }

    public class UpdatePasswordDetails : BaseResponseDetails
    {
    }

    public class UpdatePinCodeDetails : BaseResponseDetails
    {
    }

    public class RefreshTokenDetails : BaseResponseDetails
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }

    public class ValidateRefreshTokenDetails : BaseResponseDetails
    {
    }
}
