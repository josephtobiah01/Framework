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
    public class SourceOfIncomeDetails : BaseResponseDetails
    {
        public List<SourceOfIncomeResponseDataItem> SourceOfIncome { get; set; }
    }

    public class NatureOfWorkDetails : BaseResponseDetails
    {
        public List<NatureOfWorkResponseDataItem> NatureOfWork { get; set; }
    }

    public class IdentificationsDetails : BaseResponseDetails
    {
        public List<IdentificationsResponseItem> Identifications { get; set; }
    }
}
