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
    public partial class ListadoMedicos : System.Web.UI.Page
    {
        AdministracionMedicos adm = new AdministracionMedicos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable table = adm.getTabla();
                gvMedicos.DataSource = table;
                gvMedicos.DataBind();
            }
        }
    }
}