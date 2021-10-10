// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assigment_1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\_Imports.razor"
using Assigment_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\_Imports.razor"
using Assigment_1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\SearchResult.razor"
using Assigment_1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\SearchResult.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/SearchResult")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/SearchResult/{Id}")]
    public partial class SearchResult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\esben\RiderProjects\Assigment1\Assigment 1\Pages\SearchResult.razor"
 
    [Parameter]
    public string Id { get; set; }
    public IList<Adult> Adults { get; set; }
    public IList<Adult> AdultsSearched = new List<Adult>();

    protected override async Task OnInitializedAsync()
    {
        Adults = AdultService.AdultsList;
        foreach (Adult adult in Adults)
        {
            if (adult.FirstName.Contains(Id) || adult.LastName.Contains(Id))
            {
                AdultsSearched.Add(adult);
            }
        }
    }

    private void NavigateToComponent(Adult p)
    {
        NavigationManager.NavigateTo("AdultPage/" + p.Id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultService { get; set; }
    }
}
#pragma warning restore 1591
