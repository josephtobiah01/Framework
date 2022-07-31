#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System.Collections.Generic;

namespace TraxionTech.MobileFramework.Models.BusinessModels.Base
{
    public class BaseResponseDetails
    {
        public int StatusCode { get; set; }
        public List<string> Message { get; set; }
    }
}
