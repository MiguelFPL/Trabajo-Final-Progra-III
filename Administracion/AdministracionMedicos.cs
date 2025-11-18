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
    public class AdministracionMedicos
    {
        public DataTable getTabla()
        {
            DaoMedicos daoMedicos = new DaoMedicos();
            return daoMedicos.getTablaMedicos();
        }

    }
}
