using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_Red_Sismica_Registrar_Resultado_Revision_Manual.Entidades;

namespace PPAI_Red_Sismica_Registrar_Resultado_Revision_Manual.datos
{
    public class Datos
    {
        public Empleado[] generadorEmpleados() {
            // Genera un conjunto de empleados de ejemplo
            // Empleado(string apellido, string nombre, string mail, int telefono)

            Empleado[] empleados = new Empleado[5];
            empleados[0] = new Empleado("Gómez", "Juan", "juan.gomez@empresa.com", 123456789);
            empleados[1] = new Empleado("Pérez", "Lucía", "lucia.perez@empresa.com", 987654321);
            empleados[2] = new Empleado("Rodríguez", "Carlos", "carlos.rodriguez@empresa.com", 112233445);
            empleados[3] = new Empleado("Fernández", "Ana", "ana.fernandez@empresa.com", 998877665);
            empleados[4] = new Empleado("López", "María", "maria.lopez@empresa.com", 554433221);
            return empleados;
        }

        public EstacionSismologica[] generadorEstacionesSismologicas() { 
            // Genera un conjunto de estaciones sismológicas de ejemplo
            // EstacionSismologica(string nombre)

            EstacionSismologica[] estaciones = new EstacionSismologica[7];

            estaciones[0] = new EstacionSismologica("Estación Norte");
            estaciones[1] = new EstacionSismologica("Estación Sur");
            estaciones[2] = new EstacionSismologica("Estación Este");
            estaciones[3] = new EstacionSismologica("Estación Oeste");
            estaciones[4] = new EstacionSismologica("Estación Central");
            estaciones[5] = new EstacionSismologica("Estación Cordillera");
            estaciones[6] = new EstacionSismologica("Estación Costera");
            return estaciones;
        }

        public Sismografo generadorSismografos(List<SerieTemporal> seriesTemporal, EstacionSismologica[] estacionesSismologicas, String valor)
        {
            // Genera un conjunto de sismógrafos de ejemplo
            // Sismografo(string nombre, EstacionSismologica estacionSismologica, List<SerieTemporal> serieTermporal)
            Random rnd = new Random();
            Sismografo sismografo = new Sismografo("Sismógrafo" + valor, estacionesSismologicas[rnd.Next(0, 7)], seriesTemporal);
            return sismografo;
        }


        public OrigenDeGeneracion[] generadorOrigenDeGeneracion()
        {

            // 8 Orígenes de generación
            OrigenDeGeneracion[] origenes = new OrigenDeGeneracion[8];

            origenes[0] = new OrigenDeGeneracion("Sismo interplaca");
            origenes[1] = new OrigenDeGeneracion("Sismo intraplaca");
            origenes[2] = new OrigenDeGeneracion("Sismo volcánico");
            origenes[3] = new OrigenDeGeneracion("Sismo tectónico");
            origenes[4] = new OrigenDeGeneracion("Sismo por explosión de mina");
            origenes[5] = new OrigenDeGeneracion("Sismo por colapso");
            origenes[6] = new OrigenDeGeneracion("Sismo inducido por humanos");
            origenes[7] = new OrigenDeGeneracion("Sismo por fractura hidráulica");
            return origenes;
        }

        public ClasificacionSismo[] generadorClasificacionSismo()
        {

            ClasificacionSismo[] clasificaciones = new ClasificacionSismo[3];

            clasificaciones[0] = new ClasificacionSismo("Superficial (0-60 km)");
            clasificaciones[1] = new ClasificacionSismo("Intermedio (61-300 km)");
            clasificaciones[2] = new ClasificacionSismo("Profundo (301-650 km)");
            return clasificaciones;
        }

        public AlcanceSismo[] generadorAlcanceSismo() {
            // 8 Alcances (distancia epicentral)
            AlcanceSismo[] alcances = new AlcanceSismo[3];
            alcances[0] = new AlcanceSismo("Sismo Local (<100 km)");
            alcances[1] = new AlcanceSismo("Sismo Regional (100–1000 km)");
            alcances[2] = new AlcanceSismo("Tele sismo (>1000 km)");
            return alcances;
        } 


        public TipoDeDato[] generadorTipoDeDato()
        {
            // Genera un conjunto de tipos de datos de ejemplo
            // TipoDeDato(string nombre, string descripcion)
            TipoDeDato[] tiposDatos = new TipoDeDato[3];
            tiposDatos[0] = new TipoDeDato("Velocidad de onda", "Km/seg");
            tiposDatos[1] = new TipoDeDato("Frecuencia de onda", "Hz");
            tiposDatos[2] = new TipoDeDato("Longitud", "km/ciclo");
            return tiposDatos; 
        }

        public DetalleMuestra[] generadorDetalleMuestra(TipoDeDato[] tiposDatos)
        {
            DetalleMuestra[] detallesMuestra = new DetalleMuestra[3];
            Random rnd = new Random();
            detallesMuestra[0] = new DetalleMuestra( rnd.NextDouble() * 100, tiposDatos[0] );
            detallesMuestra[1] = new DetalleMuestra(rnd.NextDouble() * 100, tiposDatos[1]);
            detallesMuestra[2] = new DetalleMuestra(rnd.NextDouble() * 100, tiposDatos[2]); 
            return detallesMuestra;
        }

        public MuestraSismica generadorMuestraSismica(DetalleMuestra[] detallesMuestra) {
            //Genera una muestra sísmica de ejemplo
            MuestraSismica muestraSismica;
            
            muestraSismica = new MuestraSismica(new List<DetalleMuestra> { detallesMuestra[0], detallesMuestra[1], detallesMuestra[2] }, DateTime.Now);
            return muestraSismica;
        }

        public SerieTemporal generadorSerieTemporal()
        {
            // Genera una serie temporal de ejemplo
            // SerieTemporal(MuestraSismica muestra, EstacionSismologica estacion)
            MuestraSismica muestraSismica1 = generadorMuestraSismica(
                                                                    generadorDetalleMuestra( 
                                                                        generadorTipoDeDato() ));

            MuestraSismica muestraSismica2 = generadorMuestraSismica(
                                                                    generadorDetalleMuestra(
                                                                        generadorTipoDeDato() ));

            MuestraSismica muestraSismica3 = generadorMuestraSismica( 
                                                                    generadorDetalleMuestra(
                                                                        generadorTipoDeDato() ));  
            
            List<MuestraSismica> muestrasSismica = new List<MuestraSismica> { muestraSismica1, muestraSismica2, muestraSismica3 };
            SerieTemporal serieTemporal = new SerieTemporal(muestrasSismica);
            return serieTemporal;
        }

        public List<CambioEstado> generadorCambioEstado(Estado estado, Empleado empleado)
        {
            // Genera un cambio estado que deberia ser el autodetectado
            List<CambioEstado> cambiosEstado = new List<CambioEstado>();
            CambioEstado nuevoCambio = new CambioEstado(DateTime.Now.AddMinutes(-4), null, estado, empleado);

            return cambiosEstado;
        }


        public Estado[] generadorDeEstados()
        {
            // Genera un conjunto de estados de ejemplo
            // Estado(string nombre)
            Estado[] estados = new Estado[5];
            estados[0] = new Estado("Evento Sismico", "Autodetectado");
            estados[1] = new Estado("Evento Sismico", "Bloqueado en revision");
            estados[2] = new Estado("Evento Sismico", "Rechazar");
            estados[3] = new Estado("Evento Sismico", "derivado a experto");
            estados[4] = new Estado("Evento Sismico", "confirmado");
            return estados;
        }

        public Usuario[] generadorUsuarios(Empleado[] empleados)
        {
            Random rnd = new Random();
            // Genera un conjunto de usuarios de ejemplo
            // Usuario(string nombre, string apellido, string mail, int telefono, Empleado empleado)
            Empleado empleado1= empleados[rnd.Next(0, 4)];
            Empleado empleado3 = empleados[rnd.Next(0, 4)];
            Empleado empleado2 = empleados[rnd.Next(0, 4)];
            Usuario[] usuarios = new Usuario[3];
            usuarios[0] = new Usuario(empleado1.Nombre + empleado1.Apellido, empleado1);
            usuarios[1] = new Usuario(empleado2.Nombre + empleado2.Apellido, empleado2);
            usuarios[2] = new Usuario(empleado3.Nombre + empleado3.Apellido, empleado3);
            return usuarios;
        }

        public EventoSismico generadorEventoSismico(){
            Random rnd = new Random();
            EstacionSismologica[] estacionesSismologicas = generadorEstacionesSismologicas();
            List<SerieTemporal> seriesTemporal = new List<SerieTemporal>();
            SerieTemporal serieTemporal = generadorSerieTemporal(); // 1 serie temporal
            seriesTemporal.Add(serieTemporal);
            Sismografo sismografo = new Sismografo("Sismógrafo1", estacionesSismologicas[rnd.Next(0, 7)], seriesTemporal);
            
            Estado[] estados = generadorDeEstados();
            Empleado[] empleados = generadorEmpleados();
            List<CambioEstado> cambiosEstado = generadorCambioEstado(estados[0], empleados[rnd.Next(0, 4)]);
            AlcanceSismo[] alcancesSismos = generadorAlcanceSismo();
            OrigenDeGeneracion[] origenes = generadorOrigenDeGeneracion();
            ClasificacionSismo[] clasificaciones = generadorClasificacionSismo();
            
          
            double minLatitud = -90.0;
            double maxLatitud = 90.0;
            double minLongitud = -180.0;
            double maxLongitud = 180.0;

            double latitudEpicentro = rnd.NextDouble() * (maxLatitud - minLatitud) + minLatitud;
            double longitudEpicentro = rnd.NextDouble() * (maxLongitud - minLongitud) + minLongitud;
            double latitudHipocentro = rnd.NextDouble() * (maxLatitud - minLatitud) + minLatitud;
            double longitudHipocentro = rnd.NextDouble() * (maxLongitud - minLongitud) + minLongitud;

            double valorMagnitud = rnd.NextDouble() * 4;// Valor de magnitud entre 0 y 4

            EventoSismico eventoSismico = new EventoSismico(
                DateTime.Now.AddMinutes(-3), //hora de fin
                estados[0], // estado actual
                cambiosEstado,
                alcancesSismos[rnd.Next(0, 2)],
                origenes[rnd.Next(0, 7)],
                clasificaciones[rnd.Next(0, 2)],
                seriesTemporal,
                DateTime.Now.AddMinutes(-10), // fechaHoraOcurrencia
                latitudEpicentro, // latitudEpicentro
                longitudEpicentro, // longitudEpicentro
                latitudHipocentro, // latitudHipocentro
                longitudHipocentro, // longitudHipocentro
                valorMagnitud // valorMagnitud
                );
               
            
            return eventoSismico;
        }

    }
}
