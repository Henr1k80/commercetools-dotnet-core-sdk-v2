using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.States;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderTransitionLineItemStateAction))]
    public partial interface IStagedOrderTransitionLineItemStateAction : IStagedOrderUpdateAction
    {
        string LineItemId { get; set; }

        string LineItemKey { get; set; }

        long Quantity { get; set; }

        IStateResourceIdentifier FromState { get; set; }

        IStateResourceIdentifier ToState { get; set; }

        DateTime? ActualTransitionDate { get; set; }

    }
}
