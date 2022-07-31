#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System.Collections.Generic;
using TraxionTech.MobileFramework.Models.BusinessModels.Base;
using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Helpers;

namespace TraxionTech.MobileFramework.Models.BusinessModels
{
    public class ProvinceDetails : BaseResponseDetails
    {
        public List<ProvinceData> Provinces { get; set; }
    }
}
