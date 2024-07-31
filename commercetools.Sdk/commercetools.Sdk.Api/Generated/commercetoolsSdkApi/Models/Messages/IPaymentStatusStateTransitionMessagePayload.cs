using commercetools.Sdk.Api.Models.States;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentStatusStateTransitionMessagePayload))]
    public partial interface IPaymentStatusStateTransitionMessagePayload : IMessagePayload
    {
        IStateReference State { get; set; }

        bool Force { get; set; }

    }
}
