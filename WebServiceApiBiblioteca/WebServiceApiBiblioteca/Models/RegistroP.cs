using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceApiBiblioteca.Models
{
    public class RegistroP
    {

        public class Rootobject
        {
            public Class1[] Property1 { get; set; }
        }

        public class Class1
        {
            public int id_libro { get; set; }
            public string nombre_libro { get; set; }
            public string autor { get; set; }
            public string editorial { get; set; }
            public int cantidad_disponible { get; set; }
            public DateTime fecha_publicacion { get; set; }
            public REGISTRO_LIBRO[] REGISTRO_LIBRO { get; set; }
        }

        public class REGISTRO_LIBRO
        {
            public int id { get; set; }
            public int id_libro { get; set; }
            public int id_estudiante { get; set; }
            public DateTime fecha_registro { get; set; }
            public DateTime fecha_entrega { get; set; }
            public bool multa { get; set; }
            public string observaciones { get; set; }
            public ESTUDIANTE ESTUDIANTE { get; set; }
        }

        public class ESTUDIANTE
        {
            public int id_estudiante { get; set; }
            public string nombre_estudiante { get; set; }
            public string apellido_estudiante { get; set; }
            public float telefono_movil { get; set; }
            public string email { get; set; }
            public string grupo { get; set; }
            public int grado { get; set; }
            public object[] REGISTRO_LIBRO { get; set; }
        }

    }
}