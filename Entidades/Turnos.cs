using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turnos
    {
        private int IdTurno;
        private int IdPaciente;
        private int IdMedico;
        private int IdEspecialidad;
        private DateTime Fecha;
        private DateTime Horario;
        private String Estado;
        private String Observaciones;

        public Turnos()
        {
        }

        public int getIdTurno()
        {
            return IdTurno;
        }
        public void setIdTurno(int idTurno)
        {
            IdTurno = idTurno;
        }
        public int getIdPaciente()
        {
            return IdPaciente;
        }
        
        public void setIdPaciente(int idPaciente)
        {
            IdPaciente = idPaciente;
        }

        public int getIdMedico()
        {
            return IdMedico;
        }

        public void setIdMedico(int idMedico)
        {
            IdMedico = idMedico;
        }

        public int getIdEspecialidad()
        {
            return IdEspecialidad;
        }

        public void setIdEspecialidad(int idEspecialidad)
        {
            IdEspecialidad = idEspecialidad;
        }

        public DateTime getFecha()
        {
            return Fecha;
        }

        public void setFecha(DateTime fecha)
        {
            Fecha = fecha;
        }

        public DateTime getHorario()
        {
            return Horario;
        }

        public void setHorario(DateTime horario)
        {
            Horario = horario;
        }

        public String getEstado()
        {
            return Estado;
        }

        public void setEstado(String estado)
        {
            Estado = estado;
        }

        public String getObservaciones()
        {
            return Observaciones;
        }

        public void setObservaciones(String observaciones)
        {
            Observaciones = observaciones;
        }



    }
}
