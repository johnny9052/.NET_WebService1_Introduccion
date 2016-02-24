using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consumo_webService
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ObtenerFecha(object sender, EventArgs e)
        {
            ServiceReference1.Service1SoapClient webService = new ServiceReference1.Service1SoapClient();
            lblFecha.Text = webService.GetDate();
        }


        protected void HolaMundo(object sender, EventArgs e)
        {
            ServiceReference1.Service1SoapClient webService = new ServiceReference1.Service1SoapClient();
            lblHolaMundo.Text = webService.HelloWorld();
        }


        protected void Saludar(object sender, EventArgs e)
        {
            string nombre = txtSaludar.Text;
            ServiceReference1.Service1SoapClient webService = new ServiceReference1.Service1SoapClient();
            lblSaludar.Text = webService.Hola(nombre);
        }
    }
}