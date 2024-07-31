using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitAddressCustomTypeSetMessage : IBusinessUnitAddressCustomTypeSetMessage
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public long SequenceNumber { get; set; }

        public IReference Resource { get; set; }

        public long ResourceVersion { get; set; }

        public string Type { get; set; }

        public IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set; }

        public ICustomFields CustomFields { get; set; }

        public string OldTypeId { get; set; }

        public string AddressId { get; set; }
        public BusinessUnitAddressCustomTypeSetMessage()
        {
            this.Type = "BusinessUnitAddressCustomTypeSet";
        }
    }
}
