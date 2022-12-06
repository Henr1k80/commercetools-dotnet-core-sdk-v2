using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetAssetTagsChange))]
    public partial interface ISetAssetTagsChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IAssetChangeValue Asset { get; set; }

        IList<string> NextValue { get; set; }
        IEnumerable<string> NextValueEnumerable { set => NextValue = value.ToList(); }


        IList<string> PreviousValue { get; set; }
        IEnumerable<string> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


    }
}
