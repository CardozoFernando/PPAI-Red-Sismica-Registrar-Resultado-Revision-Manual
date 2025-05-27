using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Red_Sismica_Registrar_Resultado_Revision_Manual.Entidades
{
    public class Sesion
    {
        private DateTime fechaHoraDesde;
        private DateTime? fechaHoraHasta;
        private Usuario usuario;

        public Sesion(DateTime fechaHoraDesde, DateTime? fechaHoraHasta, Usuario usuario)
        {
            this.fechaHoraDesde = fechaHoraDesde;
            this.fechaHoraHasta = fechaHoraHasta;
            this.Usuario = usuario;
        }

        public DateTime FechaHoraDesde { get => fechaHoraDesde; set => fechaHoraDesde = value; }
        public DateTime? FechaHoraHasta { get => fechaHoraHasta; set => fechaHoraHasta = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }

        public Empleado GetEmpleado() { 
            Empleado empleado = this.Usuario.Empleado;
            return empleado;
        }
    }
}
