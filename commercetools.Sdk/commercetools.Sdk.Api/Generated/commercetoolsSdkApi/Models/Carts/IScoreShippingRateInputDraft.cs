using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ScoreShippingRateInputDraft))]
    public partial interface IScoreShippingRateInputDraft : IShippingRateInputDraft
    {
        long Score { get; set; }

    }
}
