//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiciosWeb.Datos.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class ESTUDIANTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESTUDIANTE()
        {
            this.REGISTRO_LIBRO = new HashSet<REGISTRO_LIBRO>();
        }
    
        public int id_estudiante { get; set; }
        public string nombre_estudiante { get; set; }
        public string apellido_estudiante { get; set; }
        public Nullable<decimal> telefono_movil { get; set; }
        public string email { get; set; }
        public string grupo { get; set; }
        public Nullable<int> grado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTRO_LIBRO> REGISTRO_LIBRO { get; set; }
    }
}
