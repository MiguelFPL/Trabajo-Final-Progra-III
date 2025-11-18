using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    public class DaoProvincias
    {
        AccesoDatos ds = new AccesoDatos();

        public DaoProvincias()
        {
        }

        public DataTable getTablaProvincias()
        {
            DataTable tabla = ds.ObtenerTabla("Provincia", "SELECT [id], [nombre] FROM [Provincias]");
            return tabla;
        }
    }
}
