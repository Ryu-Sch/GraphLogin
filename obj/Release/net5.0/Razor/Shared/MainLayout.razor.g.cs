#pragma checksum "C:\Dev\Testing_purposes\UnityGraphProductionTest\UnityGraphProduction\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9f051aa2b8a618346e736dcbb880c5e33a56c12"
// <auto-generated/>
#pragma warning disable 1591
namespace UnityGraphProduction.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-pttkh7s856");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-pttkh7s856");
            __builder.OpenComponent<UnityGraphProduction.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "main");
            __builder.AddAttribute(9, "b-pttkh7s856");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "top-row px-4 auth");
            __builder.AddAttribute(12, "b-pttkh7s856");
            __builder.OpenComponent<UnityGraphProduction.Shared.LoginDisplay>(13);
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.AddMarkupContent(15, "<a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-pttkh7s856>About</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n        ");
            __builder.OpenElement(17, "article");
            __builder.AddAttribute(18, "class", "content px-4");
            __builder.AddAttribute(19, "b-pttkh7s856");
#nullable restore
#line 15 "C:\Dev\Testing_purposes\UnityGraphProductionTest\UnityGraphProduction\Shared\MainLayout.razor"
__builder.AddContent(20, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591