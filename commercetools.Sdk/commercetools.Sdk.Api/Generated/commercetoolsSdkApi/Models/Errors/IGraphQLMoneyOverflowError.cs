using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLMoneyOverflowError))]
    public partial interface IGraphQLMoneyOverflowError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
