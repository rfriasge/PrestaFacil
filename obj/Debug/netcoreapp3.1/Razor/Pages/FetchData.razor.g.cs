#pragma checksum "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d957594332e7ee942538bef3005a55d763b0165a"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\FetchData.razor"
using PrestaFacil.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
#nullable restore
#line 10 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 13 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\FetchData.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenComponent<global::Radzen.Blazor.RadzenGrid<WeatherForecast>>(5);
            __builder.AddAttribute(6, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 17 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\FetchData.razor"
                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "FilterCaseSensitivity", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Radzen.FilterCaseSensitivity>(
#nullable restore
#line 17 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\FetchData.razor"
                                                             FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "FilterMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Radzen.FilterMode>(
#nullable restore
#line 18 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\FetchData.razor"
                        FilterMode.Advanced

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 18 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\FetchData.razor"
                                                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "PageSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 18 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\FetchData.razor"
                                                                          4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 18 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\FetchData.razor"
                                                                                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<WeatherForecast>>(
#nullable restore
#line 18 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\FetchData.razor"
                                                                                                        forecasts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ColumnWidth", "200px");
            __builder.AddAttribute(14, "Columns", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenGridColumn<WeatherForecast>>(16);
                __builder2.AddAttribute(17, "Property", "Date");
                __builder2.AddAttribute(18, "Title", "Date");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenGridColumn<WeatherForecast>>(20);
                __builder2.AddAttribute(21, "Property", "TemperatureC");
                __builder2.AddAttribute(22, "Title", "TemperatureC");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenGridColumn<WeatherForecast>>(24);
                __builder2.AddAttribute(25, "Property", "TemperatureF");
                __builder2.AddAttribute(26, "Title", "TemperatureF");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenGridColumn<WeatherForecast>>(28);
                __builder2.AddAttribute(29, "Property", "Summary");
                __builder2.AddAttribute(30, "Title", "Summary");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 47 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\FetchData.razor"
              
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;
    
    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591