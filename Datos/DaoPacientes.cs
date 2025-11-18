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
    public class DaoPacientes
    {
        AccesoDatos ds = new AccesoDatos();
        public DaoPacientes()
        {
        }

        public DataTable getTablaPacientes()
        {
            DataTable table = ds.ObtenerTabla("ListadoPacientes",
               "SELECT p.[dni] AS [DNI], " +
               "p.[nombre] AS [Nombre], " +
               "p.[apellido] AS [Apellido], " +
               "p.[sexo] AS [Sexo], p.[nacionalidad]  AS [Nacionalidad], " +
               "p.[direccion] AS [Direccion], " +
               "l.[nombre] AS [Localidad], " +
               "pr.[nombre] AS [Provincia], " +
               "p.[correo]  AS [Correo], " +
               "p.[telefono]  AS [Telefono] " +
               "FROM [Hospital].[dbo].[Pacientes] p " +
               "INNER JOIN [Hospital].[dbo].[Localidades] l ON p.[id_localidad] = l.[id] " +
               "INNER JOIN [Hospital].[dbo].[Provincias] pr ON l.[id_provincia] = pr.[id]");

            return table;
        }

        public Boolean existePaciente(Paciente pac)
        {
            String consulta = "SELECT * FROM [Pacientes] WHERE id =" + pac.getIdPaciente();
            return ds.existe(consulta);
        }

        public DataTable getTablaPacientesporId(int id)
        {
            DataTable tabla = ds.ObtenerTabla("Pacientes", "SELECT p.[dni], p.[nombre], p.[apellido], p.[sexo], " +
                " p.[nacionalidad],p.[fecha_nacimiento], p.[correo], p.[direccion], l.[nombre], pr.[nombre], p.[telefono]" +
                " FROM [Pacientes] p " +
                "INNER JOIN [Provincias] pr ON p.[id_provincia] = pr.[id]" +
                "INNER JOIN [Localidades] l ON p.[id_localidad] = l.[id] " +
                "WHERE p.[id] =" + id);
            return tabla;
        }

        public int AgregarPaciente(Paciente pac)
        {
            SqlCommand command = new SqlCommand();
            ArmarParametrosCategoriaAgregar(ref command, pac);
            return ds.EjecutarProcedimientoAlmacenado(command, "spAgregarPaciente");
        }

        public void ArmarParametrosCategoriaAgregar(ref SqlCommand comando, Paciente pac)
        {
            comando.Parameters.AddWithValue("@dni", pac.getDni());
            comando.Parameters.AddWithValue("@nombre", pac.getNombre());
            comando.Parameters.AddWithValue("@apellido", pac.getApellido());
            comando.Parameters.AddWithValue("@sexo", pac.getSexo());
            comando.Parameters.AddWithValue("@nacionalidad", pac.getNacionalidad());
            comando.Parameters.AddWithValue("@fecha_nacimiento", pac.getFechanacimiento());
            comando.Parameters.AddWithValue("@direccion", pac.getDireccion());
            comando.Parameters.AddWithValue("@correo", pac.getCorreo());
            comando.Parameters.AddWithValue("@id_localidad", pac.getIdLocalidad());
            comando.Parameters.AddWithValue("@telefono", pac.getTelefono());
        }
    }
}
