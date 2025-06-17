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

        public SerieTemporal(List<MuestraSismica> muestrasSismicas)
        {
            this.MuestrasSismicas = muestrasSismicas;
        }

        public List<MuestraSismica> MuestrasSismicas { get => muestrasSismicas; set => muestrasSismicas = value; }


        public List<object>  getDatos()
        {
            List<object> datosSerieTemporal = new List<object>();
            datosSerieTemporal.Add( obtenerMuestrasSismicas() );
            
            return datosSerieTemporal;
        }

        public List<object> obtenerMuestrasSismicas() {
            List<object> datosMuestraSismica = new List<object>();
            foreach (var muestra in MuestrasSismicas)
            {
                datosMuestraSismica.Add( muestra.getDatos() );
            }
            return datosMuestraSismica;
        }
    }
}
