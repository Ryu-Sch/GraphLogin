#pragma checksum "C:\Dev\Testing_purposes\UnityGraphProductionTest\UnityGraphProduction\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b60bcb598df4ed62951c24b0af9798c2047128b9"
// <auto-generated/>
#pragma warning disable 1591
namespace UnityGraphProduction.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Dev\Testing_purposes\UnityGraphProductionTest\UnityGraphProduction\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\Testing_purposes\UnityGraphProductionTest\UnityGraphProduction\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Dev\Testing_purposes\UnityGraphProductionTest\UnityGraphProduction\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Dev\Testing_purposes\UnityGraphProductionTest\UnityGraphProduction\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Dev\Testing_purposes\UnityGraphProductionTest\UnityGraphProduction\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Dev\Testing_purposes\UnityGraphProductionTest\UnityGraphProduction\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Dev\Testing_purposes\UnityGraphProductionTest\UnityGraphProduction\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Dev\Testing_purposes\UnityGraphProductionTest\UnityGraphProduction\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Dev\Testing_purposes\UnityGraphProductionTest\UnityGraphProduction\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Dev\Testing_purposes\UnityGraphProductionTest\UnityGraphProduction\_Imports.razor"
using UnityGraphProduction;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Dev\Testing_purposes\UnityGraphProductionTest\UnityGraphProduction\_Imports.razor"
using UnityGraphProduction.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "PageTitle");
            __builder.AddContent(1, "Index");
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "jumbotron");
            __builder.AddMarkupContent(5, "<h1>Blazor Client-Side Graph App</h1>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(6);
            __builder.AddAttribute(7, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(8, "h4");
                __builder2.AddContent(9, "Welcome ");
#nullable restore
#line 9 "C:\Dev\Testing_purposes\UnityGraphProductionTest\UnityGraphProduction\Pages\Index.razor"
__builder2.AddContent(10, context?.User?.Identity?.Name);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(11, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.AddMarkupContent(13, "<p>Use the navigation bar on the left to get started.</p>");
            }
            ));
            __builder.AddAttribute(14, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(15, "<a class=\"btn btn-primary btn-large\" href=\"authentication/login\">Click here to sign in</a>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591