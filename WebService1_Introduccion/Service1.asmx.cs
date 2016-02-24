using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService1_Introduccion
{
    /// <summary>
    /// Descripción breve de Service1
    /// </summary>

    /*URL donde se tendra el webservice*/
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]



    /*Para agregar una referencia a un web service:
        --Click derecho en el proyecto (no en la solucion) --> Agregar --> Referencia a servicio
        --Click en detectar o escribir la URL del webService
        --Click en Ir
        --Click en aceptar*/
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }


        [WebMethod]
        public string Hola(string nombre)
        {
            return "Hola " + nombre;
        }


        [WebMethod]
        public string GetDate()
        {
            return DateTime.Today.ToString();
        }

    }
}