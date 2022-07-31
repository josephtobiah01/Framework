#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using TraxionTech.MobileFramework.Models.BusinessModels.Base;

namespace TraxionTech.MobileFramework.Models.BusinessModels
{
    public class OtpDetails : BaseResponseDetails
    {
        public string PersonCode { get; set; }
        public string UserCode { get; set; }
    }
}
