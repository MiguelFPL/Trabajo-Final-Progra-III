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
    public class DaoLocalidades
    {
        AccesoDatos ds = new AccesoDatos();

        public DaoLocalidades()
        {
        }

        public DataTable getTablaLocalidades()
        {
            DataTable tabla = ds.ObtenerTabla("Localidad", "SELECT [id], [id_provincia], [nombre] FROM [Localidades]");
            return tabla;
        }
    }
}
