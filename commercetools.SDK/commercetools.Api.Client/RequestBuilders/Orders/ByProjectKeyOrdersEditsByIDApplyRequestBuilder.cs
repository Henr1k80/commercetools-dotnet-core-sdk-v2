using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;

namespace commercetools.Api.Client.RequestBuilders.Orders
{
   public class ByProjectKeyOrdersEditsByIDApplyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ID { get; }
   
       public ByProjectKeyOrdersEditsByIDApplyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
       }
   
       public ByProjectKeyOrdersEditsByIDApplyPost Post(commercetools.Api.Models.OrderEdits.OrderEditApply orderEditApply) {
           return new ByProjectKeyOrdersEditsByIDApplyPost(ApiHttpClient, SerializerService, ProjectKey, ID, orderEditApply);
       }
       
   }
}
