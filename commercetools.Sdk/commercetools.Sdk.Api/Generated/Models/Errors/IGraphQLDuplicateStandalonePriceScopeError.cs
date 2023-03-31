using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.StandalonePrices;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateStandalonePriceScopeError))]
    public partial interface IGraphQLDuplicateStandalonePriceScopeError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IStandalonePriceReference ConflictingStandalonePrice { get; set; }

        string Sku { get; set; }

        string Currency { get; set; }

        string Country { get; set; }

        ICustomerGroupResourceIdentifier CustomerGroup { get; set; }

        IChannelResourceIdentifier Channel { get; set; }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

    }
}
