using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Red_Sismica_Registrar_Resultado_Revision_Manual.Entidades
{
    public class SerieTemporal
    {
        private List<MuestraSismica> muestrasSismicas;

        //dependencia?
        private Sismografo sismografo;

        public SerieTemporal(List<MuestraSismica> muestrasSismicas, Sismografo sismografo)
        {
            this.muestrasSismicas = muestrasSismicas;
            this.Sismografo = sismografo;
        }

        public List<MuestraSismica> MuestrasSismicas { get => muestrasSismicas; set => muestrasSismicas = value; }
        public Sismografo Sismografo { get => sismografo; set => sismografo = value; }

        public string getDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(obtenerMuestrasSismicas());
            return sb.ToString();
        }

        public string obtenerMuestrasSismicas() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Serie Temporal de Muestras Sísmicas:");
            foreach (var muestra in muestrasSismicas)
            {
                sb.AppendLine(muestra.getDatos());
            }
            return sb.ToString();
        }

        public string obtenerEstacionSismologica() {
            StringBuilder sb = new StringBuilder();
            if (sismografo.sosDeSerieTemporal(this)) {
                sb.AppendLine("Estación Sismológica: " + sismografo.EstacionSismologica.Nombre);
            }
            return sb.ToString();
        }
    }
}
