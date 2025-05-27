namespace PPAI_Red_Sismica_Registrar_Resultado_Revision_Manual.Entidades
{
    public class TipoDeDato
    {
        private string denominacion;
        private string unidadDeMedida;

        public TipoDeDato(string denominacion, string unidadDeMedida)
        {
            this.denominacion = denominacion;
            this.unidadDeMedida = unidadDeMedida;
        }

        public string getDenominacion() 
        { 
            return denominacion;
        }

        public void setDenominacion(string denominacion) 
        { 
            this.denominacion = denominacion;
        }

        public string getUnidadDeMedida() 
        { 
            return unidadDeMedida;
        }

        public void setUnidadDeMedida(string unidadDeMedida) 
        { 
            this.unidadDeMedida = unidadDeMedida;
        }
    }
}
