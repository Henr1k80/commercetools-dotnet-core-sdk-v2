using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;

namespace commercetools.Api.Client.RequestBuilders.Subscriptions
{
   public class ByProjectKeySubscriptionsByIDRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ID { get; }
   
       public ByProjectKeySubscriptionsByIDRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
       }
   
       public ByProjectKeySubscriptionsByIDGet Get() {
           return new ByProjectKeySubscriptionsByIDGet(ApiHttpClient, ProjectKey, ID);
       }
       
       public ByProjectKeySubscriptionsByIDPost Post(commercetools.Api.Models.Subscriptions.SubscriptionUpdate subscriptionUpdate) {
           return new ByProjectKeySubscriptionsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, subscriptionUpdate);
       }
       
       public ByProjectKeySubscriptionsByIDDelete Delete() {
           return new ByProjectKeySubscriptionsByIDDelete(ApiHttpClient, ProjectKey, ID);
       }
       
   }
}
