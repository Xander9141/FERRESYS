#pragma warning disable CS8618
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;

namespace Ferresys.Models
{
    public class ApplicationDbContext : DbContext
    {


        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<EmpleadoModel> Empleados { get; set; }
        public DbSet<ProveedorModel> Proveedores { get; set; }
        public DbSet<BodegaModel> Bodegas { get; set; }
        public DbSet<ComisionesModel> Comisiones { get; set; }
        public DbSet<CompraModel> Compras { get; set; }
        public DbSet<ComunaModel> Comunas { get; set; }
        public DbSet<DescuentosModel> Descuentos { get; set; }
        public DbSet<ProveedoresProductosModel> ProvedoresProductos { get; set; }
        public DbSet<RazonSocialModel> RazonSocial { get; set; }
        public DbSet<RegionModel> Regiones { get; set; }
        public DbSet<SexoModel> Sexo { get; set; }
        public DbSet<TipoClienteModel> TipoClientes { get; set; }
        public DbSet<TipoEmpleadoModel> TipoEmpleados { get; set; }
        public DbSet<TipoPagoModel> TipoPago { get; set; }
        public DbSet<TipoPagoVentasModel> TipoPagoVentas { get; set; }
        public DbSet<VentasProductosModel> VentasProductos { get; set; }
        public DbSet<ClientesProductosModel> ClientesProductos { get; set; }
        public DbSet<ProductoModel> Productos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<VentaModel> Ventas { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}