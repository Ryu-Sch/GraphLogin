using System.Net.Http;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication.Internal;
using Microsoft.Graph;

namespace UnityGraphProduction.Authentication
{
    public class MSGraphClientFactory
    {
        private readonly IAccessTokenProviderAccessor _accessor;
        private readonly HttpClient _httpClient;
        private GraphServiceClient? _graphClient;

        public MSGraphClientFactory(IAccessTokenProviderAccessor accessor, HttpClient httpClient)
        {
            _accessor = accessor;
            _httpClient = httpClient;
        }

        public GraphServiceClient GetAuthenticatedClient()
        {
            // Use the existing one if it's there
            if (_graphClient == null)
            {
                // Create a GraphServiceClient using a scoped HttpClient
                _graphClient = new GraphServiceClient(_httpClient)
                {
                    // Configure the auth provider
                    AuthenticationProvider = new AuthenticationHeaderHandler(_accessor)
                };
            }

            return _graphClient;
        }

    }
}
