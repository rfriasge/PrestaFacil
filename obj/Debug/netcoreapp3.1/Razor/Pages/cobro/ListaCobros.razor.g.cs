#pragma checksum "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\cobro\ListaCobros.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "735d43a6576779428fd7bb502f945e28afef4afc"
// <auto-generated/>
#pragma warning disable 1591
namespace PrestaFacil.Pages.cobro
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
#line 3 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\cobro\ListaCobros.razor"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\cobro\ListaCobros.razor"
using PrestaFacil.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/cobros")]
    public partial class ListaCobros : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""container-fluid h-100 pl-0 pr-0 "">
    <div class=""d-flex flex-row w-100 justify-content-between"">
        <div class=""form-inline "">
            <h3>Cobros</h3>
        </div>

        <div style=""padding-right:0px !important; margin-right:7px !important; "">
            <a type=""button"" href=""/capturacobro"" class=""btn btn-primary"">
                <span class=""oi oi-plus"" aria-hidden=""true""></span>
                Captura Cobros
            </a>
        </div>
    </div>
</div>
");
#nullable restore
#line 23 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\cobro\ListaCobros.razor"
 if (lstCobros == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>No existen registros</p>    \r\n");
#nullable restore
#line 26 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\cobro\ListaCobros.razor"
}
else{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-group mt-1");
            __builder.AddMarkupContent(5, "\r\n        \r\n    ");
            __builder.OpenComponent<global::Radzen.Blazor.RadzenGrid<Cobro_cabecera>>(6);
            __builder.AddAttribute(7, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 30 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\cobro\ListaCobros.razor"
                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "FilterCaseSensitivity", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Radzen.FilterCaseSensitivity>(
#nullable restore
#line 30 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\cobro\ListaCobros.razor"
                                                             FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 30 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\cobro\ListaCobros.razor"
                                                                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "PageSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 30 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\cobro\ListaCobros.razor"
                                                                                                                                 10

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 31 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\cobro\ListaCobros.razor"
                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<Cobro_cabecera>>(
#nullable restore
#line 31 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\cobro\ListaCobros.razor"
                                           lstCobros

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ColumnWidth", "150px");
            __builder.AddAttribute(14, "class", "table table-bordered table-striped table-hover ");
            __builder.AddAttribute(15, "Columns", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenGridColumn<Cobro_cabecera>>(17);
                __builder2.AddAttribute(18, "Property", "Fecha");
                __builder2.AddAttribute(19, "Title", "Fecha");
                __builder2.AddAttribute(20, "Width", "10%");
                __builder2.AddAttribute(21, "FormatString", "{0:dd/MM/yyyy}");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n                ");
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenGridColumn<Cobro_cabecera>>(23);
                __builder2.AddAttribute(24, "Property", "Concepto");
                __builder2.AddAttribute(25, "Title", "Concepto");
                __builder2.AddAttribute(26, "Width", "40%");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                ");
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenGridColumn<Cobro_cabecera>>(28);
                __builder2.AddAttribute(29, "Title", "Acción");
                __builder2.AddAttribute(30, "Width", "6.8%");
                __builder2.AddAttribute(31, "Property", "Id");
                __builder2.AddAttribute(32, "Template", (global::Microsoft.AspNetCore.Components.RenderFragment<Cobro_cabecera>)((data) => (__builder3) => {
                    __builder3.AddMarkupContent(33, "\r\n                        ");
                    __builder3.OpenElement(34, "button");
                    __builder3.AddAttribute(35, "type", "button");
                    __builder3.AddAttribute(36, "data-toggle", "modal");
                    __builder3.AddAttribute(37, "data-target", "#dlgCliente");
                    __builder3.AddAttribute(38, "value", "Ed");
                    __builder3.AddAttribute(39, "class", "btn btn-primary btn-sm oi oi-pencil");
                    __builder3.AddAttribute(40, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\cobro\ListaCobros.razor"
                                                                                                                                                               () => prepararEdit(@data)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(41, "\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\r\n    \r\n \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 46 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\cobro\ListaCobros.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\cobro\ListaCobros.razor"
       
    public List<Cobro_cabecera> lstCobros;
    public Cobro_cabecera cobro_cabecera = new Cobro_cabecera();
    public string TituloPantalla = "";
    private int Id = 0;
    NavigationManager navigationManager;
    protected override async Task OnInitializedAsync()
    {
        lstCobros = await cobroService.Get();
    }



    private void prepararEdit(Cobro_cabecera cc)
    {
        cobro_cabecera = cc;
    }


    private void prepararDelete(int id)
    {
        Id = id;
    }

    private async void DataChanged()
    {
        lstCobros = await cobroService.Get();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICobroService cobroService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591