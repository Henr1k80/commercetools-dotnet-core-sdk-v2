using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeOrderStateChange))]
    public partial interface IChangeOrderStateChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IOrderState PreviousValue { get; set; }

        IOrderState NextValue { get; set; }

    }
}
