#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

namespace TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Authentication
{
    public class UpdatePasswordStageRequest
    {
        public string personCode { get; set; }
        public string userCode { get; set; }
        public string newPassword { get; set; }
        public string newPasswordConfirm { get; set; }
    }
}
