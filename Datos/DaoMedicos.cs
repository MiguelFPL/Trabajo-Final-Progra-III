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
    public class DaoMedicos
    {
        AccesoDatos ds = new AccesoDatos();

        public DaoMedicos()
        {
        }

        public DataTable getTablaMedicos()
        {
            DataTable tabla = ds.ObtenerTabla("ListadoMedicos", @"
            SELECT  
                m.[id]               AS [Legajo],
                m.[dni]              AS [DNI],
                m.[nombre]           AS [Nombre],
                m.[apellido]         AS [Apellido],
                m.[sexo]             AS [Sexo],
                m.[nacionalidad]     AS [Nacionalidad],
                m.[correo]           AS [Correo],
                m.[fecha_nacimiento] AS [FechaNacimiento],
                m.[direccion]        AS [Direccion],
                l.[nombre]           AS [Localidad],
                p.[nombre]           AS [Provincia],
                m.[telefono]         AS [Telefono],
                e.[nombre]           AS [Especialidad],
                CONCAT(
                    ISNULL(ha.[dia_semana], ''),
                    ' ',
                    ISNULL(ha.[hora_inicio], ''),
                    ' - ',
                    ISNULL(ha.[hora_fin], '')
                ) AS [DiasHorariosAtencion]
            FROM [Hospital].[dbo].[Medicos] m
            INNER JOIN [Hospital].[dbo].[Localidades]    l  ON m.[id_localidad]    = l.[id]
            INNER JOIN [Hospital].[dbo].[Provincias]     p  ON l.[id_provincia]    = p.[id]
            INNER JOIN [Hospital].[dbo].[Especialidades] e  ON m.[id_especialidad] = e.[id]
            LEFT JOIN  [Hospital].[dbo].[Horarios_Atencion] ha ON m.[id] = ha.[id_medico];
            ");
            return tabla;
        }

        public Boolean existeMedico(Medico med)
        {
            String consulta = "SELECT * FROM [Medicos] WHERE id =" + med.getIdMedico();
            return ds.existe(consulta);
        }

        public DataTable getTablaMedicosporId(int id)
        {
            DataTable tabla = ds.ObtenerTabla("Medicos", "SELECT m.[id], m.[dni], m.[nombre], m.[apellido], m.[sexo], " +
                " m.[nacionalidad],m.[fecha_nacimiento], m.[correo], m.[direccion], l.[nombre], p.[provincia], m.[telefono]," +
                "e.[nombre], m.[dias_atencion], m.[horario_atencion]" +
                " FROM [Medicos] m " +
                "INNER JOIN [Localidades] l ON m.[id_localidad] = l.[id]" +
                "INNER JOIN [Provincias] p ON m.[id_provincia] = p.[id]" +
                "INNER JOIN [Especialidades] e ON m.[id_especialidad] = e.[id] " +
                "WHERE m.[id] =" + id);
            return tabla;
        }

        public int AgregarMedico(Medico med)
        {
            SqlCommand command = new SqlCommand();
            ArmarParametrosCategoriaAgregar(ref command, med);
            return ds.EjecutarProcedimientoAlmacenado(command, "spAgregarMedico");
        }

        public void ArmarParametrosCategoriaAgregar(ref SqlCommand command, Medico med)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = command.Parameters.Add("@dni", SqlDbType.VarChar);
            SqlParametros.Value = med.getDni();
            SqlParametros = command.Parameters.Add("@nombre", SqlDbType.VarChar);
            SqlParametros.Value = med.getNombre();
            SqlParametros = command.Parameters.Add("@apellido", SqlDbType.VarChar);
            SqlParametros.Value = med.getApellido();
            SqlParametros = command.Parameters.Add("@sexo", SqlDbType.VarChar);
            SqlParametros.Value = med.getSexo();
            SqlParametros = command.Parameters.Add("@nacionalidad", SqlDbType.VarChar);
            SqlParametros.Value = med.getNacionalidad();
            SqlParametros = command.Parameters.Add("@fecha_nacimiento", SqlDbType.Date);
            SqlParametros.Value = med.getFechanacimiento();
            SqlParametros = command.Parameters.Add("@correo", SqlDbType.VarChar);
            SqlParametros.Value = med.getCorreo();
            SqlParametros = command.Parameters.Add("@direccion", SqlDbType.VarChar);
            SqlParametros.Value = med.getDireccion();
            SqlParametros = command.Parameters.Add("@id_localidad", SqlDbType.Int);
            SqlParametros.Value = med.getIdLocalidad();
            SqlParametros = command.Parameters.Add("@telefono", SqlDbType.VarChar);
            SqlParametros.Value = med.getTelefono();
            SqlParametros = command.Parameters.Add("@id_especialidad", SqlDbType.Int);
            SqlParametros.Value = med.getIdEspecialidad();
            SqlParametros = command.Parameters.Add("@dias_atencion", SqlDbType.VarChar);
            SqlParametros.Value = med.getDiasDeAtencion();
            SqlParametros = command.Parameters.Add("@horario_atencion", SqlDbType.VarChar);
            SqlParametros.Value = med.getHorariosDeAtencion();
        }

        public int EliminarMedico(Medico med)
        {
            SqlCommand command = new SqlCommand();
            ArmarParametrosCategoriaEliminar(ref command, med);
            return ds.EjecutarProcedimientoAlmacenado(command, "spEliminarMedico");
        }

        public void ArmarParametrosCategoriaEliminar(ref SqlCommand command, Medico med)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = command.Parameters.Add("@id", SqlDbType.Int);
            SqlParametros.Value = med.getIdMedico();
        }
    }
}
