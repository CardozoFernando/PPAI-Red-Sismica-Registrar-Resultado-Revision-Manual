using PPAI_Red_Sismica_Registrar_Resultado_Revision_Manual.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Red_Sismica_Registrar_Resultado_Revision_Manual.objetos
{
    public class GestorRegRevisionManual
    {
        private List<Sismografo> sismografos;
        private List<Estado> estados;
        private List<EventoSismico> eventosSismico;
        private Sesion sesionActual;
        private Empleado? empleadoActual;


        public GestorRegRevisionManual(List<Sismografo> sismografos, List<Estado> estados, 
            List<EventoSismico> eventosSismico, Sesion sesionActual, Empleado empleado)
        {
            this.Sismografos = sismografos;
            this.Estados = estados;
            this.EventosSismico = eventosSismico;
            this.sesionActual = sesionActual;
            this.empleadoActual = empleado;
        }

        public List<Sismografo> Sismografos { get => sismografos; set => sismografos = value; }
        public List<Estado> Estados { get => estados; set => estados = value; }
        public List<EventoSismico> EventosSismico { get => eventosSismico; set => eventosSismico = value; }
        public Sesion SesionActual { get => sesionActual; set => sesionActual = value; }
        public Empleado? EmpleadoActual { get => empleadoActual; set => empleadoActual = value; }


        public void buscarEmpleadoEnSesion()
        {
            Empleado empleado;
            Usuario usuario = SesionActual.Usuario;
            empleado = usuario.Empleado;
            this.EmpleadoActual = empleado;
        }

        public List<EventoSismico> obtenerEventosSismicosAutodetectados()
        {
            List<EventoSismico> eventosFiltrados = new List<EventoSismico>();
            foreach (var evento in EventosSismico)
            {
                if (evento.esAutodectado())
                {
                    eventosFiltrados.Add(evento);
                }
            }
            return eventosFiltrados;
        }

        public List<EventoSismico> ordenarEventos(List<EventoSismico> eventosFiltrados)
        {
            List<EventoSismico> eventosOrdenados = eventosFiltrados.OrderBy(obj => obj.FechaHoraOcurrencia).ToList();
            return eventosOrdenados;
        }

        public List<object> obtenerDatosPrincipalesEvento(List<EventoSismico> eventosFiltrados)

        {
            List<object> datosPrincipales = new List<object>();
            foreach (var evento in eventosFiltrados)
            {
                List<object> datosEvento = evento.obtenerDatosPrincipales();
                datosPrincipales.Add(datosEvento);
            }
            return datosPrincipales;
        }

        
    }
}
