using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetShippingRateInputChange))]
    public partial interface ISetShippingRateInputChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        Object PreviousValue { get; set; }

        Object NextValue { get; set; }

    }
}
