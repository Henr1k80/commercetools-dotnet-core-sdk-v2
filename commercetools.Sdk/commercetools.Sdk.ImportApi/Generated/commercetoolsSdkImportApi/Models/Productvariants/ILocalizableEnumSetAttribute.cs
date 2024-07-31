using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.LocalizableEnumSetAttribute))]
    public partial interface ILocalizableEnumSetAttribute : IAttribute
    {
        IList<string> Value { get; set; }

        IEnumerable<string> ValueEnumerable { set => Value = value.ToList(); }

    }
}
