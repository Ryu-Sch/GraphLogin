using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication.Internal;
using Microsoft.Graph;

namespace UnityGraphProduction.Authentication
{
    public class AuthenticationHeaderHandler : DelegatingHandler, IAuthenticationProvider
    {
        private readonly IAccessTokenProviderAccessor _accessor;



        public AuthenticationHeaderHandler(IAccessTokenProviderAccessor accessor)
        {
            _accessor = accessor;
        }


        public async Task AuthenticateRequestAsync(HttpRequestMessage request)
        {
            // Request the token from the accessor
            var result = await _accessor.TokenProvider.RequestAccessToken();

            if (result.TryGetToken(out var token))
            {
                // Add the token to the Authorization header
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token.Value);
            }
        }
    }
}
