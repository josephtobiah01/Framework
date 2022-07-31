#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System.Collections.Generic;
using TraxionTech.MobileFramework.Models.BusinessModels.Base;
using TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Transactions;

namespace TraxionTech.MobileFramework.Models.BusinessModels
{
    public class TransactionDetails : BaseResponseDetails
    {
        public string MobileNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public double Amount { get; set; }
    }

    public class BillerDetails : BaseResponseDetails
    {
        public List<BillerCategoryResponseDataItem> BillerCategories { get; set; }
    }

    public class BillersByCategoryDetails : BaseResponseDetails
    {
        public List<BillersByCategoryResponseDataItem> BillersByCategory { get; set; }
    }
}
