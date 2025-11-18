using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private int IdUsuario;
        private int IdMedico;
        private String TipoUsuario;
        private String NombreUsuario;
        private String Contrasena;
        private bool Estado;

        public Usuario()
        {
        }
        public int getIdUsuario()
        {
            return IdUsuario;
        }
        
        public void setIdUsuario(int idUsuario)
        {
            IdUsuario = idUsuario;
        }
        public int getIdMedico()
        {
            return IdMedico;
        }
        public void setIdMedico(int idMedico)
        {
            IdMedico = idMedico;
        }
        public String getTipoUsuario()
        {
            return TipoUsuario;
        }

        public void setTipoUsuario(String tipoUsuario)
        {
            TipoUsuario = tipoUsuario;
        }

        public String getNombreUsuario()
        {
            return NombreUsuario;
        }

        public void setNombreUsuario(String nombreUsuario)
        {
            NombreUsuario = nombreUsuario;
        }

        public String getContrasena()
        {
            return Contrasena;
        }

        public void setContrasena(String contrasena)
        {
            Contrasena = contrasena;
        }
    }
}
