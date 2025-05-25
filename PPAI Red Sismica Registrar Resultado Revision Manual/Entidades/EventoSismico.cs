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
        private List<EventoSismico> todosEventosSismicos = new List<EventoSismico>();
        private List<Estado> todosEstados = new List<Estado>();
        private EventoSismico eventoSismicoSeleccionado;
        private Pantalla pantallaRegRevisionManual;
            /*
            - todosEstados
            -pantallaRegRevisionManual
            - todosEventosSismicos
            - eventoSismicoSeleccionado
            - datosAlcanceClasificacionOrigen
            - datosEvento
            - seleccionAccion
            - sesion
            - aSLogueado
            */
        public EventoSismico(DateTime fechaHoraFinal) //constructor
        {
            fechaHoraFin = fechaHoraFinal;
            
        }

        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
    }
}
