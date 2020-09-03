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
    
    public partial class Contrato
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contrato()
        {
            this.ContratoDetalle = new HashSet<ContratoDetalle>();
        }
    
        public string cont_idEmpresa { get; set; }
        public string cont_idTrabajador { get; set; }
        public string cont_fecha { get; set; }
        public string cont_numero { get; set; }
        public string cont_descripcion { get; set; }
        public string cont_fechaInicio { get; set; }
        public string cont_fechaFinal { get; set; }
        public string cont_estado { get; set; }
    
        public virtual Empresa Empresa { get; set; }
        public virtual Trabajador Trabajador { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContratoDetalle> ContratoDetalle { get; set; }
    }
}