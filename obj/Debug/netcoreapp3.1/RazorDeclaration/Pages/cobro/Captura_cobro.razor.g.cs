// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\cobro\Captura_cobro.razor"
using PrestaFacil.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/capturacobro")]
    public partial class Captura_cobro : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "D:\desarrollo\app_blazor\PrestaFacil\PrestaFacil\Pages\cobro\Captura_cobro.razor"
       
    public Cobro_cabecera CobCab = new Cobro_cabecera();

    public List<Cobrador> lstCobrador;
    private IEnumerable<VwPrestamosClientes> lstPrestamosCliente = new List<VwPrestamosClientes>();
    private List<Tipo_transaccion> lstTipoTransaccion = new List<Tipo_transaccion>();
    private List<Cliente> lstClientes = new List<Cliente>();
    private List<Prestamo> lstPrestamos = new List<Prestamo>();
    List<VwClientePrestamoDetalle> lstPrestamoDetalle = new List<VwClientePrestamoDetalle>();
    private Cliente ClienteSeleccionado = new Cliente();
    private List<Cobro_detalle> lstCobroDetalle = new List<Cobro_detalle>();
    private string nombre_cliente = "";
    private int contador = 1;
    RadzenGrid<Cobro_detalle> Grid;
    RadzenGrid<VwClientePrestamoDetalle> GridPrestamosCliente;

    protected override async Task OnInitializedAsync()
    {

        CobCab.cobro_detalle = new List<Cobro_detalle>();
        CobCab.Fecha = DateTime.Now;
        lstCobrador =  await cobradorService.Get();
        lstTipoTransaccion = await tipoTransaccionService.Get();
        lstClientes = await clienteService.Get();
        lstPrestamos = await prestamoService.Get();


    }
    private async void validarFormulario()
    {

    }

    private async void seleccionaCliente(int Id, string pnombre)
    {


        CobCab.Concepto = pnombre;
        nombre_cliente = pnombre;
        CobCab.ClienteId = Id;
        lstCobroDetalle = new List<Cobro_detalle>();
        lstPrestamoDetalle = prestamoDetalleService.GetPrestamoDetalleCliente(Id).OrderBy(a=>a.PrestamoId).OrderBy(a=>a.NoCuota).ToList();




    }

    private void seleccionaCuota(int pPrestamoId, int pNoCuota, string pnombreCliente)
    {
        Cobro_detalle valorCuota = new Cobro_detalle();
        valorCuota = cobroService.getcuota(pPrestamoId, pNoCuota, 2);

        if(valorCuota != null)
        {
            notificationService.Notify(new NotificationMessage
                {
                    Severity = NotificationSeverity.Success,
                    Summary = "Información",
                    Detail = "Cuota ya fue pagada",
                    Duration = 4000
                });
        }
        else
        {

            bool valida = false;
            Cobro_detalle cuota = new Cobro_detalle();
            //nombre_cliente = pnombreCliente;
            //CobCab.Concepto = pnombreCliente;
            var pc = prestamoDetalleService.GetPrestamoCuota(pPrestamoId, pNoCuota);
            Tipo_transaccion tt = tipoTransaccionService.Get(2);
            cuota.NoCuota = pNoCuota;
            cuota.Cuota = (decimal)pc.MontoCuota;
            cuota.PrestamoId = pc.PrestamoId;
            cuota.des_tipo_transaccion = tt.Descripcion;
            cuota.Tipo_transaccionId = 2;
            try
            {
                Cobro_detalle cd = new Cobro_detalle();
                cd = lstCobroDetalle.Where(x => x.PrestamoId == cuota.PrestamoId && x.NoCuota == cuota.NoCuota).FirstOrDefault();

                if (cd == null)
                {
                    lstCobroDetalle.Add(cuota);
                }


                CobCab.cobro_detalle = lstCobroDetalle;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Grid.Reload();
        }
    }

    private void borrar_cobro(Cobro_detalle cd)
    {
        lstCobroDetalle.Remove(cd);
        Grid.Reload();
    }

    private async  void aplicarPago()
    {

        if (CobCab.ClienteId == 0)
        {
            notificationService.Notify(new NotificationMessage
                {
                    Severity = NotificationSeverity.Success,
                    Summary = "Información",
                    Detail = "Primero debe seleccionar el cliente",
                    Duration = 4000
                });
        }
        else if (lstCobroDetalle.Count == 0)
        {
            notificationService.Notify(new NotificationMessage
                {
                    Severity = NotificationSeverity.Success,
                    Summary = "Información",
                    Detail = "No hay detalle de pagos, verifique",
                    Duration = 4000
                });
        }
        else
        {
            CobCab.Feccre = DateTime.Now;
            CobCab.Fecmod = DateTime.Now;
            var cob =  cobroService.Add(CobCab);
            CobCab = new Cobro_cabecera();
            lstCobroDetalle = new List<Cobro_detalle>();
            lstPrestamoDetalle = prestamoDetalleService.GetPrestamoDetalleCliente(CobCab.ClienteId).OrderBy(a=>a.PrestamoId).OrderBy(a=>a.NoCuota).ToList();
            GridPrestamosCliente.Reload();
            
            notificationService.Notify(new NotificationMessage
                {
                    Severity = NotificationSeverity.Success,
                    Summary = "Información",
                    Detail = "Pago aplicado correctamente",
                    Duration = 4000
                });
            
            OnInitializedAsync();
        }        

    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService notificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICobroService cobroService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPrestamoDetalleService prestamoDetalleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPrestamoService prestamoService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClienteService clienteService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITipoTransaccionService tipoTransaccionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICobradorService cobradorService { get; set; }
    }
}
#pragma warning restore 1591
