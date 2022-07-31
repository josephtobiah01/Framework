#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

namespace TraxionTech.MobileFramework.BusinessControllers.Interfaces.Traxionpay
{
    public interface ISessionController
    {
        string PersonCode { get; set; }
        string UserCode { get; set; }
        string AccessToken { get; set; }
        string RefreshToken { get; set; }
        string SecretKey { get; set; }
        int IsApproved { get; set; }
    }
}
