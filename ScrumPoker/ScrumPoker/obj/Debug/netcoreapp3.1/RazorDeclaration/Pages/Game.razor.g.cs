#pragma checksum "C:\Users\shubsh.FAREAST\source\repos\ScrumPoker\ScrumPoker\Pages\Game.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "841b3ed3fe68bedb4212129a4c654a84ae0f76fa"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ScrumPoker.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\shubsh.FAREAST\source\repos\ScrumPoker\ScrumPoker\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shubsh.FAREAST\source\repos\ScrumPoker\ScrumPoker\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\shubsh.FAREAST\source\repos\ScrumPoker\ScrumPoker\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\shubsh.FAREAST\source\repos\ScrumPoker\ScrumPoker\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\shubsh.FAREAST\source\repos\ScrumPoker\ScrumPoker\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\shubsh.FAREAST\source\repos\ScrumPoker\ScrumPoker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\shubsh.FAREAST\source\repos\ScrumPoker\ScrumPoker\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\shubsh.FAREAST\source\repos\ScrumPoker\ScrumPoker\_Imports.razor"
using ScrumPoker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\shubsh.FAREAST\source\repos\ScrumPoker\ScrumPoker\_Imports.razor"
using ScrumPoker.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/game/{GameId}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/game/{GameId}/{User}")]
    public partial class Game : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\shubsh.FAREAST\source\repos\ScrumPoker\ScrumPoker\Pages\Game.razor"
 

    [Parameter]
    public string GameId { get; set; }

    [Parameter]
    public string User { get; set; }

    [Inject]
    public NavigationManager navService { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        if(string.IsNullOrEmpty(GameId) || !Guid.TryParse(GameId, out Guid id))
        {
            navService.NavigateTo("/error/InValidGameId");
        }


    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
