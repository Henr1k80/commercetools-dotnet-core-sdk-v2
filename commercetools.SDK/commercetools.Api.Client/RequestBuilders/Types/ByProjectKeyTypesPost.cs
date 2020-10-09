using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Types
{
   public partial class ByProjectKeyTypesPost : ApiMethod<ByProjectKeyTypesPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private commercetools.Api.Models.Types.TypeDraft TypeDraft;
   
       public ByProjectKeyTypesPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Api.Models.Types.TypeDraft typeDraft) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.TypeDraft = typeDraft;
           this.RequestUrl = $"/{ProjectKey}/types";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyTypesPost WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.Types.Type> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Types.Type>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(TypeDraft);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body);
              }
          }
          return request;
       }
   }
}
