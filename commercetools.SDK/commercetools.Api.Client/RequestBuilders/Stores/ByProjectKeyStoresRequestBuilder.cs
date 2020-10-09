using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;
using commercetools.Api.Client.RequestBuilders.Stores;

namespace commercetools.Api.Client.RequestBuilders.Stores
{
   public class ByProjectKeyStoresRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyStoresRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyStoresGet Get() {
           return new ByProjectKeyStoresGet(ApiHttpClient, ProjectKey);
       }
       
       public ByProjectKeyStoresPost Post(commercetools.Api.Models.Stores.StoreDraft storeDraft) {
           return new ByProjectKeyStoresPost(ApiHttpClient, SerializerService, ProjectKey, storeDraft);
       }
       
       public ByProjectKeyStoresKeyByKeyRequestBuilder WithKey(string key) {
           return new ByProjectKeyStoresKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
       }
       public ByProjectKeyStoresByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeyStoresByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
       }
   }
}
