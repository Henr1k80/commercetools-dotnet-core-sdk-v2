using commercetools.Sdk.Api.Models.AssociateRoles;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.AssociateRolePermissionsSetMessage))]
    public partial interface IAssociateRolePermissionsSetMessage : IMessage
    {
        IList<IPermission> Permissions { get; set; }

        IEnumerable<IPermission> PermissionsEnumerable { set => Permissions = value.ToList(); }

    }
}
