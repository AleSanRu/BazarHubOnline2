//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SWLNBazarHub.EnlaceDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            this.CarritoCompras = new HashSet<CarritoCompras>();
            this.ComentariosValoraciones = new HashSet<ComentariosValoraciones>();
            this.DetallesFactura = new HashSet<DetallesFactura>();
            this.DetallesPedido = new HashSet<DetallesPedido>();
            this.Devoluciones = new HashSet<Devoluciones>();
        }
    
        public int ProductoID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<int> Stock { get; set; }
        public Nullable<int> CategoriaID { get; set; }
        public Nullable<int> ProveedorID { get; set; }
        public string Estado { get; set; }
        public Nullable<System.DateTime> FechaDeEdicion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarritoCompras> CarritoCompras { get; set; }
        public virtual Categorias Categorias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComentariosValoraciones> ComentariosValoraciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallesFactura> DetallesFactura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallesPedido> DetallesPedido { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Devoluciones> Devoluciones { get; set; }
        public virtual Inventario Inventario { get; set; }
        public virtual Proveedores Proveedores { get; set; }
    }
}