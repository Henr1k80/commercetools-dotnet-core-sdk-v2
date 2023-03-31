using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionVariantExclusionChangedMessagePayload))]
    public partial interface IProductSelectionVariantExclusionChangedMessagePayload : IMessagePayload
    {
        IProductReference Product { get; set; }

        IProductVariantExclusion OldVariantExclusion { get; set; }

        IProductVariantExclusion NewVariantExclusion { get; set; }

    }
}
