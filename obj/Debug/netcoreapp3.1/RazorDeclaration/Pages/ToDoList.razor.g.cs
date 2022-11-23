// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PrestaFacil.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\_Imports.razor"
using PrestaFacil;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\_Imports.razor"
using PrestaFacil.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\ToDoList.razor"
using PrestaFacil.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\ToDoList.razor"
using PrestaFacil.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\ToDoList.razor"
using PrestaFacil.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/todolist")]
    public partial class ToDoList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\ToDoList.razor"
       
    List<ToDo> toDoList;
    ToDo taskObject = new ToDo();
    string customHeader = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        toDoList = await service.Get();
    }
    private void InitializeTaskObject()
    {
        taskObject = new ToDo();
        taskObject.DueDate = DateTime.Now;
        customHeader = "Add New Task";
    }
    private async void DataChanged()
    {
        toDoList = await service.Get();
        StateHasChanged();
    }

    private void PrepareForEdit(ToDo task)
    {
        taskObject = task;
        customHeader = "Edit Task";
    }
    private void PrepareForDelete(ToDo task)
    {
        taskObject = task;
    }
    private async Task Delete()
    {
        var task = await service.Delete(taskObject.Id);
        await jsRuntime.InvokeAsync<object>("CloseModal", "confirmDeleteModal");
        toDoList = await service.Get();
        taskObject = new ToDo();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToDoListService service { get; set; }
    }
}
#pragma warning restore 1591
