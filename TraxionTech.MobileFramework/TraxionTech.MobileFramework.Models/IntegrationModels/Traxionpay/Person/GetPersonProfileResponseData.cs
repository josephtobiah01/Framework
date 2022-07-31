#region Copyright
// ==================================================================================================
//   This file is part of the Traxion Tech Development Platform.
//   Copyright © Traxion Tech Inc. All rights reserved.
// ==================================================================================================
#endregion

using System.Collections.Generic;

namespace TraxionTech.MobileFramework.Models.IntegrationModels.Traxionpay.Person
{
    public class GetPersonProfileResponseData
    {
        public List<GetPersonProfileResponsePerson> person { get; set; }
    }
}
