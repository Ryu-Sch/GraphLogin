using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace UnityGraphProduction.Authentication
{
    public class GraphAPIAuthorizationMessageHandler : AuthorizationMessageHandler
    {
        public GraphAPIAuthorizationMessageHandler(IAccessTokenProvider provider, NavigationManager navigation) : base(provider, navigation)
        {
            ConfigureHandler(
                authorizedUrls: new[] { "https://graph.microsoft.com" },
                scopes: new[] { "https://graph.microsoft.com/User.Read", "https://graph.microsoft.com/Mail.Read" }
                );
        }

    }
}
