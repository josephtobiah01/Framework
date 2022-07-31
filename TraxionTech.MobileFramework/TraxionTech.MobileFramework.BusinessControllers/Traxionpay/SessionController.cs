#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using TraxionTech.MobileFramework.BusinessControllers.Interfaces.Traxionpay;

namespace TraxionTech.MobileFramework.BusinessControllers.Traxionpay
{
    public class SessionController : ISessionController
    {
        public string PersonCode { get; set; }
        public string UserCode { get; set; }
        public string AccessToken { get; set; }
        public string SecretKey { get; set; }
        public string RefreshToken { get; set; }
        public int IsApproved { get; set; }
    }
}
