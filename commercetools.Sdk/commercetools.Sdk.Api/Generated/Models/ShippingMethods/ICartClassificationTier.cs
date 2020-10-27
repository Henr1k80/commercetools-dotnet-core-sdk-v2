using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.CartClassificationTier))]
    public interface ICartClassificationTier : IShippingRatePriceTier
    {
        string Value { get; set;}
        
        IMoney Price { get; set;}
        
        bool? IsMatching { get; set;}
    }
}
