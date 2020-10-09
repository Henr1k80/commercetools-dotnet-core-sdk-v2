using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;

namespace commercetools.Api.Client.RequestBuilders.ProductTypes
{
   public class ByProjectKeyProductTypesKeyByKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string Key { get; }
   
       public ByProjectKeyProductTypesKeyByKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.Key = key;
       }
   
       public ByProjectKeyProductTypesKeyByKeyGet Get() {
           return new ByProjectKeyProductTypesKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
       }
       
       public ByProjectKeyProductTypesKeyByKeyPost Post(commercetools.Api.Models.ProductTypes.ProductTypeUpdate productTypeUpdate) {
           return new ByProjectKeyProductTypesKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, productTypeUpdate);
       }
       
       public ByProjectKeyProductTypesKeyByKeyDelete Delete() {
           return new ByProjectKeyProductTypesKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
       }
       
   }
}
