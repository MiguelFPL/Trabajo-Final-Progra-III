using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datos
{
    class AccesoDatos
    {
        string rutaBDSucursales = "Data Source=localhost\\sqlexpress;Initial Catalog=Hospital;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        public AccesoDatos()
        {
        }

        private SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(rutaBDSucursales);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private SqlDataAdapter ObtenerAdaptador(String ConsultaSql, SqlConnection cn)
        {
            SqlDataAdapter Adaptador;
            try
            {
                Adaptador = new SqlDataAdapter(ConsultaSql, cn);
                return Adaptador;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public DataTable ObtenerTabla(String NombreTabla, String Sql)
        {
            DataSet ds = new DataSet();
            SqlConnection conexion = ObtenerConexion();
            SqlDataAdapter adaptador = ObtenerAdaptador(Sql, conexion);
            adaptador.Fill(ds, NombreTabla);
            conexion.Close();
            return ds.Tables[NombreTabla];
        }

        public int EjecutarProcedimientoAlmacenado(SqlCommand comando, String NombreSP)
        {
            int FilasCambiadas;
            SqlConnection conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = comando;
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreSP;
            FilasCambiadas = cmd.ExecuteNonQuery();
            conexion.Close();
            return FilasCambiadas;
        }

        public Boolean existe(String Consulta)
        {
            Boolean estado = false;
            SqlConnection conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand(Consulta, conexion);
            SqlDataReader datos = cmd.ExecuteReader();
            if (datos.Read())
            {
                estado = true;
            }
            return estado;
        }

        public int ObtenerMaximo(String Consulta)
        {
            int max = 0;
            SqlConnection conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand(Consulta, conexion);
            SqlDataReader datos = cmd.ExecuteReader();
            if (datos.Read())
            {
                max = Convert.ToInt32(datos[0].ToString());
            }
            return max;
        }
    }
}
