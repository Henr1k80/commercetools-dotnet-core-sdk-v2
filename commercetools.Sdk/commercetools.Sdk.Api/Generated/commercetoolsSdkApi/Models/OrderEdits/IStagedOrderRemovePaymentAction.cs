using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Payments;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemovePaymentAction))]
    public partial interface IStagedOrderRemovePaymentAction : IStagedOrderUpdateAction
    {
        IPaymentResourceIdentifier Payment { get; set; }

    }
}
