using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Models.CustomerGroups;
using Xunit;
using static commercetools.Api.IntegrationTests.CustomerGroup.CustomerGroupFixtures;

namespace commercetools.Api.IntegrationTests.CustomerGroup
{
    [Collection("Integration Tests")]
    public class CustomerIntegrationTests
    {
        private readonly IClient _client;
        private readonly string _projectKey;

        public CustomerIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            var clientConfiguration = serviceProviderFixture.GetClientConfiguration("Client");
            this._client = serviceProviderFixture.GetService<IClient>();
            this._projectKey = clientConfiguration.ProjectKey;
        }

        [Fact]
        public async Task CreateCustomerGroup()
        {
            var key = $"CreateCustomer-{TestingUtility.RandomString()}";
            await WithCustomerGroup(
                _client,
                customerGroupDraft => DefaultCustomerGroupDraftWithKey(customerGroupDraft, key),
                customerGroup => { Assert.Equal(key, customerGroup.Key); }
            );
        }

        [Fact]
        public async Task GetCustomerGroupById()
        {
            var key = $"GetCustomerById-{TestingUtility.RandomString()}";
            await WithCustomerGroup(
                _client,
                customerDraft => DefaultCustomerGroupDraftWithKey(customerDraft, key),
                async customerGroup =>
                {
                    Assert.NotNull(customerGroup);
                    var retrievedCustomer = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .CustomerGroups()
                        .WithId(customerGroup.Id)
                        .Get()
                        .ExecuteAsync();

                    Assert.NotNull(retrievedCustomer);
                    Assert.Equal(key, retrievedCustomer.Key);
                }
            );
        }

        [Fact]
        public async Task QueryCustomersGroup()
        {
            var key = $"QueryCustomers-{TestingUtility.RandomString()}";
            await WithCustomerGroup(
                _client,
                customerDraft => DefaultCustomerGroupDraftWithKey(customerDraft, key),
                async customerGroup =>
                {
                    Assert.NotNull(customerGroup);
                    var returnedSet = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .CustomerGroups()
                        .Get()
                        .WithQuery(q => q.Key().Is(customerGroup.Key))
                        .ExecuteAsync();

                    Assert.Single(returnedSet.Results);
                    Assert.Equal(key, returnedSet.Results[0].Key);
                });
        }

        [Fact]
        public async Task UpdateCustomerGroupByIdChangeKey()
        {
            await WithUpdateableCustomerGroup(
                _client,
                async customerGroup =>
                {
                    Assert.NotNull(customerGroup);
                    var name = $"{TestingUtility.RandomString()}";
                    var action = new CustomerGroupSetKeyAction()
                    {
                        Action = "setKey",
                        Key = name
                    };

                    var update = new CustomerGroupUpdate()
                    {
                        Version = customerGroup.Version,
                        Actions = new List<ICustomerGroupUpdateAction>() { action }
                    };

                    var updatedCustomerGroup = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .CustomerGroups()
                        .WithId(customerGroup.Id)
                        .Post(update)
                        .ExecuteAsync();

                    Assert.Equal(updatedCustomerGroup.Key, name);
                    return updatedCustomerGroup;
                }
            );
        }
    }
}