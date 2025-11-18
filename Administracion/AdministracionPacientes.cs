using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Data;
using System.Data.SqlClient;

namespace Administracion
{
    public class AdministracionPacientes
    {
        public DataTable getTabla()
        {
            DaoPacientes daoPacientes = new DaoPacientes();
            return daoPacientes.getTablaPacientes();
        }
    }
}
