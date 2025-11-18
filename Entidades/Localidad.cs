using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Localidad
    {
        private int IdLocalidad;
        private int IdProvincia;
        private String NombreLocalidad;
        public Localidad()
        {
        }
        public int getIdLocalidad()
        {
            return IdLocalidad;
        }
        public void setIdLocalidad(int idLocalidad)
        {
            IdLocalidad = idLocalidad;
        }

        public int getIdProvincia()
        {
            return IdProvincia;
        }

        public void setIdProvincia(int idProvincia)
        {
            IdProvincia = idProvincia;
        }
        public String getNombreLocalidad()
        {
            return NombreLocalidad;
        }
        public void setNombreLocalidad(String nombreLocalidad)
        {
            NombreLocalidad = nombreLocalidad;
        }
    }
}
