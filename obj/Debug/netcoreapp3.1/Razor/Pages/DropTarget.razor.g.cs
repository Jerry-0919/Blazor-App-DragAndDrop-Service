#pragma checksum "F:\Blood\second\Project\BlazorApp\Pages\DropTarget.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b297b4fc45f95961f3d3f299740b109ff90ca08"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Blood\second\Project\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Blood\second\Project\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Blood\second\Project\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Blood\second\Project\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Blood\second\Project\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Blood\second\Project\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Blood\second\Project\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Blood\second\Project\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Blood\second\Project\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Blood\second\Project\BlazorApp\_Imports.razor"
using jQWidgets.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\Blood\second\Project\BlazorApp\Pages\DropTarget.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    public partial class DropTarget<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "ondragover", "event.preventDefault()");
            __builder.AddAttribute(2, "ondrop", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 7 "F:\Blood\second\Project\BlazorApp\Pages\DropTarget.razor"
                                                   OnDrop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddContent(4, 
#nullable restore
#line 8 "F:\Blood\second\Project\BlazorApp\Pages\DropTarget.razor"
     ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "F:\Blood\second\Project\BlazorApp\Pages\DropTarget.razor"
       
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public int Zone { get; set; }

    [Parameter]
    public Action<Employee> Drop { get; set; }

    void OnDrop()
    {
        if (Drop != null && DragAndDropService.Data.Score < Zone)
        {
            Drop((Employee)DragAndDropService.Data);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService EmployeeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DragAndDropService DragAndDropService { get; set; }
    }
}
#pragma warning restore 1591
