using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ApprovalRuleNameSetMessage))]
    public partial interface IApprovalRuleNameSetMessage : IMessage
    {
        string Name { get; set; }

        string OldName { get; set; }

    }
}
