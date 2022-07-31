#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System.Collections.Generic;
using TraxionTech.MobileFramework.Models.BusinessModels.Base;
using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Users;

namespace TraxionTech.MobileFramework.Models.BusinessModels
{
    public class UsersDetails : BaseResponseDetails
    {     
        public double CurrentBalance { get; set; }
        public double AvailableBalance { get; set; }     
    }

    public class TransactionsDetails : BaseResponseDetails
    {
        public List<TransactionsResponseItem> Transactions { get; set; }
    }
}
