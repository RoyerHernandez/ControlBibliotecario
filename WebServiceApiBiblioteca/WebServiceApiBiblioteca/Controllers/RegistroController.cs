using ServiciosWeb.Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebServiceApiBiblioteca.Controllers
{
    public class RegistroController : ApiController
    {

        ROYER_PRUEBASEntities BD = new ROYER_PRUEBASEntities();


        /// <summary>
        /// Consulta la información de los registros realizados al prestar los libres en la biblioteca
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<REGISTRO_LIBRO> Get()
        {
            var listado = BD.REGISTRO_LIBRO.ToList();

            return listado;
        }


        [HttpGet]
        public REGISTRO_LIBRO Get(int id)
        {
            var registro = BD.REGISTRO_LIBRO.FirstOrDefault(x=> x.id == id );

            return registro;
        }

    }
}
