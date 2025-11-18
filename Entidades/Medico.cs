using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico
    {
        private int IdMedico;
        private int IdLocalidad;
        private int IdEspecialidad;
        private String Dni;
        private String Nombre;
        private String Apellido;
        private String Sexo;
        private String Nacionalidad;
        private DateTime FechaNacimiento;
        private String Direccion;
        private String Correo;
        private String Telefono;
        private String DiasDeAtencion;
        private String HorariosDeAtencion;

        public Medico()
        {
        }

        public int getIdMedico()
        {
            return IdMedico;
        }

        public void setIdMedico(int idMedico)
        {
            IdMedico = idMedico;
        }

        public int getIdLocalidad()
        {
            return IdLocalidad;
        }

        public void setIdLocalidad(int idLocalidad)
        {
            IdLocalidad = idLocalidad;
        }

        public int getIdEspecialidad()
        {
            return IdEspecialidad;
        }

        public void setIdEspecialidad(int idEspecialidad)
        {
            IdEspecialidad = idEspecialidad;
        }

        public String getDni()
        {
            return Dni;
        }

        public void setDni(String dni)
        {
            Dni = dni;
        }

        public String getNombre()
        {
            return Nombre;
        }

        public void setNombre(String nombre)
        {
            Nombre = nombre;
        }

        public String getApellido()
        {
            return Apellido;
        }

        public void setApellido(String apellido)
        {
            Apellido = apellido;
        }

        public String getSexo()
        {
            return Sexo;
        }

        public void setSexo(String sexo)
        {
            Sexo = sexo;
        }

        public String getNacionalidad()
        {
            return Nacionalidad;
        }

        public void setNacionalidad(String nacionalidad)
        {
            Nacionalidad = nacionalidad;
        }

        public DateTime getFechanacimiento()
        {
            return FechaNacimiento;
        }

        public void setFechanacimiento(DateTime fechanacimiento)
        {
            FechaNacimiento = fechanacimiento;
        }

        public String getDireccion()
        {
            return Direccion;
        }

        public void setDireccion(String direccion)
        {
            Direccion = direccion;
        }

        public String getCorreo()
        {
            return Correo;
        }

        public void setCorreo(String correo)
        {
            Correo = correo;
        }

        public String getTelefono()
        {
            return Telefono;
        }

        public void setTelefono(String telefono)
        {
            Telefono = telefono;
        }

        public String getDiasDeAtencion()
        {
            return DiasDeAtencion;
        }

        public void setDiasDeAtencion(String diasDeAtencion)
        {
            DiasDeAtencion = diasDeAtencion;
        }

        public String getHorariosDeAtencion()
        {
            return HorariosDeAtencion;
        }

        public void setHorariosDeAtencion(String horariosDeAtencion)
        {
            HorariosDeAtencion = horariosDeAtencion;
        }
    }
}
