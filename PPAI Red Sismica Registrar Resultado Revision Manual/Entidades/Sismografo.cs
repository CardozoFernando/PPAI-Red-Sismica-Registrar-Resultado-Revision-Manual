using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Red_Sismica_Registrar_Resultado_Revision_Manual.Entidades
{
    public class Sismografo
    {
        private string nombre;
        private EstacionSismologica estacionSismologica;
        private List<SerieTemporal> serieTermporal;


        public Sismografo(string nombre, EstacionSismologica estacionSismologica, List<SerieTemporal> serieTermporal)
        {
            this.nombre = nombre;
            this.estacionSismologica = estacionSismologica;
            this.SerieTermporal = serieTermporal;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public EstacionSismologica EstacionSismologica { get => estacionSismologica; set => estacionSismologica = value; }
        public List<SerieTemporal> SerieTermporal { get => serieTermporal; set => serieTermporal = value; }

        public string getDatos()
        {
            return "Nombre: " + nombre + ", Estación Sismológica: " + estacionSismologica.getNombre();
        }

        public bool sosDeSerieTemporal(SerieTemporal serieTemporal)
        {
            if (serieTermporal.Contains(serieTemporal))
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}
