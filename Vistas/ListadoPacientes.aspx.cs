using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Administracion;
using Entidades;

namespace Vistas
{
    public partial class ListadoPacientes : System.Web.UI.Page
    {
        AdministracionPacientes adm = new AdministracionPacientes();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable table = adm.getTabla();
                gvPacientes.DataSource = table;
                gvPacientes.DataBind();
            }
        }
    }
}