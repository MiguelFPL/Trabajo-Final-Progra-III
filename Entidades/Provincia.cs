using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincia
    {
        private int IdProvincia;
        private String NombreProvincia;
        public Provincia()
        {
        }
        public int getIdProvincia()
        {
            return IdProvincia;
        }
        public void setIdProvincia(int idProvincia)
        {
            IdProvincia = idProvincia;
        }
        public String getNombreProvincia()
        {
            return NombreProvincia;
        }
        public void setNombreProvincia(String nombreProvincia)
        {
            NombreProvincia = nombreProvincia;
        }
    }
}
