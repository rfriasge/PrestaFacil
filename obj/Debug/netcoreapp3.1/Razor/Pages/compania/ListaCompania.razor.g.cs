#pragma checksum "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\compania\ListaCompania.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47ee9e82dd768491d8f0709b315c643db6bb6f05"
// <auto-generated/>
#pragma warning disable 1591
namespace PrestaFacil.Pages.compania
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
#line 3 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\compania\ListaCompania.razor"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\compania\ListaCompania.razor"
using PrestaFacil.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/companias")]
    public partial class ListaCompania : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""container-fluid h-100 pl-0 pr-0 "">
    <div class=""d-flex flex-row w-100 justify-content-between"">
        <div class=""form-inline "">
            <h3>Compañias</h3>
        </div>

        <div style=""padding-right:0px !important; margin-right:7px !important; "">
            <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#dlgCompania"">
                <span class=""oi oi-plus"" aria-hidden=""true""></span>
                Crear Compañia
            </button>
        </div>
    </div>
</div>
");
#nullable restore
#line 23 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\compania\ListaCompania.razor"
 if (lstCompania == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>No existen registros</p>    \r\n");
#nullable restore
#line 26 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\compania\ListaCompania.razor"
} 
else{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-group mt-1");
            __builder.AddMarkupContent(5, "\r\n        \r\n    ");
            __builder.OpenComponent<global::Radzen.Blazor.RadzenGrid<Compania>>(6);
            __builder.AddAttribute(7, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 30 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\compania\ListaCompania.razor"
                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "FilterCaseSensitivity", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Radzen.FilterCaseSensitivity>(
#nullable restore
#line 30 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\compania\ListaCompania.razor"
                                                             FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 30 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\compania\ListaCompania.razor"
                                                                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "PageSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 30 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\compania\ListaCompania.razor"
                                                                                                                                 10

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 31 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\compania\ListaCompania.razor"
                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<Compania>>(
#nullable restore
#line 31 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\compania\ListaCompania.razor"
                                           lstCompania

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ColumnWidth", "150px");
            __builder.AddAttribute(14, "class", "table table-bordered table-striped table-hover rz-has-paginator rz-datatable  rz-datatable-scrollable rz-datatable-reflow");
            __builder.AddAttribute(15, "Columns", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenGridColumn<Compania>>(17);
                __builder2.AddAttribute(18, "Property", "Nombre");
                __builder2.AddAttribute(19, "Title", "Nombre");
                __builder2.AddAttribute(20, "Width", "53%");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n                ");
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenGridColumn<Compania>>(22);
                __builder2.AddAttribute(23, "Property", "Rnc");
                __builder2.AddAttribute(24, "Title", "RNC");
                __builder2.AddAttribute(25, "Width", "13%");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n                ");
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenGridColumn<Compania>>(27);
                __builder2.AddAttribute(28, "Property", "Telefono1");
                __builder2.AddAttribute(29, "Title", "Telefono 1");
                __builder2.AddAttribute(30, "Width", "13%");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n                ");
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenGridColumn<Compania>>(32);
                __builder2.AddAttribute(33, "Property", "Telefono2");
                __builder2.AddAttribute(34, "Title", "Telefono 2");
                __builder2.AddAttribute(35, "Width", "13%");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n                ");
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenGridColumn<Compania>>(37);
                __builder2.AddAttribute(38, "Title", "Acción");
                __builder2.AddAttribute(39, "Width", "6.8%");
                __builder2.AddAttribute(40, "Property", "Id");
                __builder2.AddAttribute(41, "Template", (global::Microsoft.AspNetCore.Components.RenderFragment<Compania>)((data) => (__builder3) => {
                    __builder3.AddMarkupContent(42, "\r\n                        ");
                    __builder3.OpenElement(43, "button");
                    __builder3.AddAttribute(44, "type", "button");
                    __builder3.AddAttribute(45, "data-toggle", "modal");
                    __builder3.AddAttribute(46, "data-target", "#dlgCompania");
                    __builder3.AddAttribute(47, "value", "Ed");
                    __builder3.AddAttribute(48, "class", "btn btn-primary btn-sm oi oi-pencil");
                    __builder3.AddAttribute(49, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\compania\ListaCompania.razor"
                                                                                                                                                                () => prepararEdit(@data)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(50, "\r\n                        ");
                    __builder3.OpenElement(51, "button");
                    __builder3.AddAttribute(52, "type", "button");
                    __builder3.AddAttribute(53, "data-toggle", "modal");
                    __builder3.AddAttribute(54, "data-target", "#dlgBorrar");
                    __builder3.AddAttribute(55, "value", "");
                    __builder3.AddAttribute(56, "class", "btn btn-primary btn-sm oi oi-trash");
                    __builder3.AddAttribute(57, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\compania\ListaCompania.razor"
                                                                                                                                                                () => prepararDelete(@data.Id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(60, "\r\n    \r\n \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 48 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\compania\ListaCompania.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::PrestaFacil.Pages.compania.FormularioCompania>(62);
            __builder.AddAttribute(63, "Id", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 49 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\compania\ListaCompania.razor"
                        Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "compania", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::PrestaFacil.Models.Compania>(
#nullable restore
#line 49 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\compania\ListaCompania.razor"
                                      compania

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "TituloPantalla", "TituloPantalla");
            __builder.AddAttribute(66, "DataChanged", (global::System.Action)(
#nullable restore
#line 49 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\compania\ListaCompania.razor"
                                                                                              DataChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(67, "\r\n");
            __builder.OpenComponent<global::PrestaFacil.Pages.compania.BorraCompania>(68);
            __builder.AddAttribute(69, "CiaId", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 50 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\compania\ListaCompania.razor"
                      Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "compania", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::PrestaFacil.Models.Compania>(
#nullable restore
#line 50 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\compania\ListaCompania.razor"
                                    compania

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "DataChanged", (global::System.Action)(
#nullable restore
#line 50 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\compania\ListaCompania.razor"
                                                            DataChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\compania\ListaCompania.razor"
       
    public bool MostrarModal = true;
    public List<Compania> lstCompania;
    public Compania compania = new Compania();
    public string TituloPantalla = "";
    private int Id = 0;
    NavigationManager navigationManager;
    protected override async Task OnInitializedAsync()
    {

        lstCompania = await companiaServicio.Get();


    }

    //private void crear()
    //{
    //    MostrarModal = true;

    //}
    //protected override Task OnAfterRenderAsync(bool firstRender)
    //{
    //    //var esta_inicializada = JS.InvokeVoidAsync("esta_inicializada");
    //    //JS.InvokeVoidAsync("InitTable");

    //    return base.OnAfterRenderAsync(firstRender);
    //}

    private void prepararEdit(Compania cia)
    {
        compania = cia;

    }


    private void prepararDelete(int id)
    {
        Id = id;
    }

    private async void DataChanged()
    {
        
        lstCompania = await companiaServicio.Get();
        //await JS.InvokeVoidAsync("reload");
        //lstCompania = await companiaServicio.Get();
       // StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompaniaService companiaServicio { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
