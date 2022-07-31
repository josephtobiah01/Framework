#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System.Collections.Generic;

namespace TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Transactions
{
    public class BillersByCategoryResponseDataItem
    {
        public int institutionID { get; set; }
        public string institutionCode { get; set; }
        public string name { get; set; }
        public int billerCategoryID { get; set; }
        public string logo { get; set; }
        public int isActive { get; set; }
        public double feeAmount { get; set; }
        public List<BillersByCategoryResponseDataAggregator> aggregator { get; set; }
    }
}
