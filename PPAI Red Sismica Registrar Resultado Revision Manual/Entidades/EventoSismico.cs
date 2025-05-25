using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Red_Sismica_Registrar_Resultado_Revision_Manual.Entidades
{
    public class EventoSismico
    {
        private DateTime fechaHoraFin;

        public EventoSismico(DateTime fechaHoraFin)
        {
            this.FechaHoraFin = fechaHoraFin;
        }

        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
    }
}
