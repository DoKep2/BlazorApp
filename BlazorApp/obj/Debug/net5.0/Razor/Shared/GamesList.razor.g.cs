#pragma checksum "C:\Users\sergo\RiderProjects\BlazorApp\BlazorApp\Shared\GamesList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5be7680843dd07c9a639f4783d2dfbe2362cdde8"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sergo\RiderProjects\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sergo\RiderProjects\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sergo\RiderProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sergo\RiderProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sergo\RiderProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sergo\RiderProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sergo\RiderProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sergo\RiderProjects\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sergo\RiderProjects\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sergo\RiderProjects\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    public partial class GamesList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "table-responsive");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-striped");
            __builder.OpenElement(4, "thead");
            __builder.AddAttribute(5, "class", "thead-light");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "<th>Name</th>\r\n            ");
            __builder.AddMarkupContent(8, "<th>Genre</th>\r\n            ");
            __builder.AddMarkupContent(9, "<th>Year</th>\r\n            ");
            __builder.OpenElement(10, "th");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "checkbox");
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\sergo\RiderProjects\BlazorApp\BlazorApp\Shared\GamesList.razor"
                                                  (() => displayButton ^= true)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "tbody");
#nullable restore
#line 14 "C:\Users\sergo\RiderProjects\BlazorApp\BlazorApp\Shared\GamesList.razor"
         if (Games == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "<tr>LOADING...</tr>");
#nullable restore
#line 17 "C:\Users\sergo\RiderProjects\BlazorApp\BlazorApp\Shared\GamesList.razor"
        }
        else if(Games.Count == 0)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "<tr>NO ITEMS IN ARRAY</tr>");
#nullable restore
#line 21 "C:\Users\sergo\RiderProjects\BlazorApp\BlazorApp\Shared\GamesList.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\sergo\RiderProjects\BlazorApp\BlazorApp\Shared\GamesList.razor"
             foreach (var game in Games)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorApp.Shared.IndividualGame>(18);
            __builder.AddAttribute(19, "Game", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorApp.Game>(
#nullable restore
#line 26 "C:\Users\sergo\RiderProjects\BlazorApp\BlazorApp\Shared\GamesList.razor"
                                      game

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "IsTable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\sergo\RiderProjects\BlazorApp\BlazorApp\Shared\GamesList.razor"
                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "DisplayButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\sergo\RiderProjects\BlazorApp\BlazorApp\Shared\GamesList.razor"
                                                                          displayButton

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 27 "C:\Users\sergo\RiderProjects\BlazorApp\BlazorApp\Shared\GamesList.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\sergo\RiderProjects\BlazorApp\BlazorApp\Shared\GamesList.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\sergo\RiderProjects\BlazorApp\BlazorApp\Shared\GamesList.razor"
       
    [Parameter]
    public List<Game> Games { get; set; }

    private bool displayButton = false;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
