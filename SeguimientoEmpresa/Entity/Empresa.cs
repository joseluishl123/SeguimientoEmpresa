//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SeguimientoEmpresa.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empresa()
        {
            this.Contrato = new HashSet<Contrato>();
            this.Sucursal = new HashSet<Sucursal>();
        }
    
        public string emp_nit { get; set; }
        public string emp_razonSocial { get; set; }
        public string emp_telefono { get; set; }
        public string emp_email { get; set; }
        public string emp_paginaWeb { get; set; }
        public string emp_direccion { get; set; }
        public string emp_representanteLegar { get; set; }
        public string emp_telefonoRepresentante { get; set; }
        public string emp_contrato { get; set; }
        public byte[] emp_foto1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrato> Contrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sucursal> Sucursal { get; set; }
    }
}