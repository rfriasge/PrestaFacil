#pragma checksum "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\prestamo\ConfirmaCreaPrestamo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d533e5118f731475e678354be7f820a7d4803304"
// <auto-generated/>
#pragma warning disable 1591
namespace PrestaFacil.Pages.prestamo
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
using PrestaFacil.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\_Imports.razor"
using PrestaFacil.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\prestamo\ConfirmaCreaPrestamo.razor"
using PrestaFacil.Services;

#line default
#line hidden
#nullable disable
    public partial class ConfirmaCreaPrestamo : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade");
            __builder.AddAttribute(2, "style", "width:30% !important; margin-left:45% !important; margin-top:50px !important;");
            __builder.AddAttribute(3, "tabindex", "-1");
            __builder.AddAttribute(4, "role", "dialog");
            __builder.AddAttribute(5, "id", "dlgConfirmacion");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "modal-dialog");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-content");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "modal-header");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.AddMarkupContent(16, "<h5 class=\"modal-title\">Confirmation Creación de Préstamo</h5>\r\n                    ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\prestamo\ConfirmaCreaPrestamo.razor"
                                                    OnModalClose

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "class", "close");
            __builder.AddAttribute(21, "data-dismiss", "modal");
            __builder.AddAttribute(22, "aria-label", "Close");
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.AddMarkupContent(24, "<span aria-hidden=\"true\">×</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "modal-body");
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.AddMarkupContent(30, "<p>Esta seguro que desea crear este préstamo?</p>\r\n                ");
            __builder.OpenElement(31, "p");
            __builder.AddContent(32, "Al cliente ");
            __builder.OpenElement(33, "span");
            __builder.AddAttribute(34, "style", "color:blue !important; font-weight:bold !important;");
#nullable restore
#line 19 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\prestamo\ConfirmaCreaPrestamo.razor"
__builder.AddContent(35, nombre_cliente);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddContent(36, " ?");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "modal-footer");
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "type", "button");
            __builder.AddAttribute(44, "class", "btn btn-primary");
            __builder.AddAttribute(45, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\prestamo\ConfirmaCreaPrestamo.razor"
                                                                        CrearPrestamo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(46, "Crear");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "type", "button");
            __builder.AddAttribute(50, "class", "btn btn-secondary");
            __builder.AddAttribute(51, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\prestamo\ConfirmaCreaPrestamo.razor"
                                                                          OnModalClose

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "data-dismiss", "modal");
            __builder.AddContent(53, "Cancelar");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\prestamo\ConfirmaCreaPrestamo.razor"
       

    [Parameter] public Action DataChanged { get; set; }
    [Parameter] public EventCallback CrearPrestamo { get; set; }
    [Parameter] public string nombre_cliente { get; set; }

    private async void OnModalClose()
    {
        navigationManager.NavigateTo("/calculoprestamo");
        await jsRuntime.InvokeAsync<object>("CloseModal", "dlgConfirmacion");
        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClienteService clienteServicio { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
