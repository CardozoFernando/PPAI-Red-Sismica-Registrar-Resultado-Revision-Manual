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
            this.sismografo = sismografo;
        }

        public List<MuestraSismica> MuestrasSismicas { get => muestrasSismicas; set => muestrasSismicas = value; }
        public Sismografo Sismografo { get => sismografo; set => sismografo = value; }

        public List<object>  getDatos()
        {
            List<object> datosSerieTemporal = new List<object>();
            datosSerieTemporal.Add( obtenerMuestrasSismicas());
            
            return datosSerieTemporal;
        }

        public List<object> obtenerMuestrasSismicas() {
            List<object> datosMuestraSismica = new List<object>();
            foreach (var muestra in muestrasSismicas)
            {
                datosMuestraSismica.Add( muestra.getDatos() );
            }
            return datosMuestraSismica;
        }

        public string obtenerEstacionSismologica() {
            StringBuilder sb = new StringBuilder();
            if (sismografo.sosDeSerieTemporal(this)) {
                sb.AppendLine("Estación Sismológica: " + this.Sismografo.EstacionSismologica.Nombre);
            }
            return sb.ToString();
        }
    }
}
