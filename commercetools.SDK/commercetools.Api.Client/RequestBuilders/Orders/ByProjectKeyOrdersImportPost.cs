using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Orders
{
   public partial class ByProjectKeyOrdersImportPost : ApiMethod<ByProjectKeyOrdersImportPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private commercetools.Api.Models.Orders.OrderImportDraft OrderImportDraft;
   
       public ByProjectKeyOrdersImportPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Api.Models.Orders.OrderImportDraft orderImportDraft) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.OrderImportDraft = orderImportDraft;
           this.RequestUrl = $"/{ProjectKey}/orders/import";
       }
   
   

       public async Task<commercetools.Api.Models.Orders.Order> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Orders.Order>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(OrderImportDraft);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body);
              }
          }
          return request;
       }
   }
}
