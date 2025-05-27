using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Red_Sismica_Registrar_Resultado_Revision_Manual.Entidades
{
    public class CambioEstado
    {

        private DateTime fechaHoraInicio;
        private DateTime? fechaHoraFin;  //el signo de pregunta indica que es nullable, lo que significa que puede ser null
        private Estado estado;
        private Empleado empleado;

        public CambioEstado(DateTime fechaHoraInicio, DateTime? fechaHoraFin, Estado estado, Empleado empleado)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFin = fechaHoraFin;
            this.estado = estado;
            this.empleado = empleado;
        }

        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public Estado Estado { get => estado; set => estado = value; }
        public Empleado Empleado { get => empleado; set => empleado = value; }
        public DateTime? FechaHoraFin1 { get => fechaHoraFin; set => fechaHoraFin = value; }

        public bool esEstadoActual() 
        {
            return FechaHoraFin1 == null; 
        }
    }

}
