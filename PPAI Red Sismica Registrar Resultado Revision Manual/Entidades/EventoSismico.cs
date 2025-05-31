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
        private Estado estadoActual;
        private List<CambioEstado> cambioEstado;
        private AlcanceSismo alcanceSismico;
        private OrigenDeGeneracion origenDeGeneracion;
        private ClasificacionSismo clasificacionSismo;
        private List<SerieTemporal> serieTemporal;
        private DateTime fechaHoraOcurrencia;
        private double latitudEpicentro;
        private double longitudEpicentro;
        private double latitudHipocentro;
        private double longitudHipocentro;
        private double valorMagnitud;

        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
        public Estado EstadoActual { get => estadoActual; set => estadoActual = value; }
        public List<CambioEstado> CambioEstado { get => cambioEstado; set => cambioEstado = value; }
        public AlcanceSismo AlcanceSismico { get => alcanceSismico; set => alcanceSismico = value; }
        public OrigenDeGeneracion OrigenDeGeneracion { get => origenDeGeneracion; set => origenDeGeneracion = value; }
        public ClasificacionSismo ClasificacionSismo { get => clasificacionSismo; set => clasificacionSismo = value; }
        public List<SerieTemporal> SerieTemporal { get => serieTemporal; set => serieTemporal = value; }
        public DateTime FechaHoraOcurrencia { get => fechaHoraOcurrencia; set => fechaHoraOcurrencia = value; }
        public double LatitudEpicentro { get => latitudEpicentro; set => latitudEpicentro = value; }
        public double LongitudEpicentro { get => longitudEpicentro; set => longitudEpicentro = value; }
        public double LatitudHipocentro { get => latitudHipocentro; set => latitudHipocentro = value; }
        public double LongitudHipocentro { get => longitudHipocentro; set => longitudHipocentro = value; }
        public double ValorMagnitud { get => valorMagnitud; set => valorMagnitud = value; }

        public EventoSismico(DateTime fechaHoraFin, Estado estadoActual, List<CambioEstado> cambioEstado,
            AlcanceSismo alcanceSismico, OrigenDeGeneracion origenDeGeneracion,
            ClasificacionSismo clasificacionSismo, List<SerieTemporal> serieTemporal, DateTime fechaHoraOcurrencia,
            double latitudEpicentro, double longitudEpicentro, double latitudHipocentro, double longitudHipocentro, double valorMagnitud)
        {
            this.FechaHoraFin = fechaHoraFin;
            this.EstadoActual = estadoActual;
            this.CambioEstado = cambioEstado;
            this.AlcanceSismico = alcanceSismico;
            this.OrigenDeGeneracion = origenDeGeneracion;
            this.ClasificacionSismo = clasificacionSismo;
            this.SerieTemporal = serieTemporal;
            this.FechaHoraOcurrencia = fechaHoraOcurrencia;
            this.LatitudEpicentro = latitudEpicentro;
            this.LongitudEpicentro = longitudEpicentro;
            this.LatitudHipocentro = latitudHipocentro;
            this.LongitudHipocentro = longitudHipocentro;
            this.ValorMagnitud = valorMagnitud;
        }

        public bool esAutodectado()
        {
            return this.EstadoActual.esAutodetectado();
        }

        public List<object> obtenerDatosPrincipales()
        {
            List<object> datosPrincipales = new List<object>();

            datosPrincipales.Add(this.FechaHoraOcurrencia);   // DateTime
            datosPrincipales.Add(this.LatitudEpicentro);      // double
            datosPrincipales.Add(this.LongitudEpicentro);     // double
            datosPrincipales.Add(this.LatitudHipocentro);     // double
            datosPrincipales.Add(this.LongitudHipocentro);    // double
            datosPrincipales.Add(this.ValorMagnitud);         // double

            return datosPrincipales;
        }

        public void bloquearEnRevision(Estado estadoBloqueado, Empleado empleadoACargo)
        {
            buscarEstadoActual(); // Busca el estado actual y actualiza su fechaHoraFin
            this.EstadoActual = estadoBloqueado;
            crearCambioEstado(estadoBloqueado, empleadoACargo);
        }

        public void buscarEstadoActual()
        {
            foreach (CambioEstado cambio_estado in this.CambioEstado)
            {
                if (cambio_estado.esEstadoActual())
                {
                    DateTime fechaHoraFin = DateTime.Now;
                    cambio_estado.FechaHoraFin = fechaHoraFin;
                }
            }
        }

        public void crearCambioEstado(Estado nuevoEstado, Empleado empleadoACargo)
        {
            DateTime fechaHoraInicio = DateTime.Now;
            DateTime? fechaHoraFin = null; // o una fecha válida si la tenés

            CambioEstado nuevoCambio = new CambioEstado(fechaHoraInicio, fechaHoraFin, nuevoEstado, empleadoACargo);

            // Ahora lo podés agregar a una lista, por ejemplo:
            this.CambioEstado.Add(nuevoCambio);
        }

        public List<string> getDatosRestantes()
        {
            List<string> datosRestantes = new List<string>();
            string origen_Generacion = this.OrigenDeGeneracion.Nombre;
            string alcanceSismo = this.alcanceSismico.Nombre;
            string clasificacionSismo = this.clasificacionSismo.Nombre;
            datosRestantes.Add(origen_Generacion);
            datosRestantes.Add(alcanceSismo);
            datosRestantes.Add(clasificacionSismo);
            return datosRestantes;
        }

        public List<object> obtenerDatosSerieTemporal() {
            List<object> datosSerieTemporal = new List<object>();
            foreach (SerieTemporal serieTemporal in this.SerieTemporal) {
                datosSerieTemporal.Add( serieTemporal.getDatos() );
            }
            return datosSerieTemporal;
        }

        public void rechazar(Estado estadoRechazado, Empleado empleadoACargo)
        {
            buscarEstadoActual(); // Busca el estado actual y actualiza su fechaHoraFin
            this.EstadoActual = estadoRechazado; // set estado actual
            crearCambioEstado(estadoRechazado, empleadoACargo);

        }
    }
}
