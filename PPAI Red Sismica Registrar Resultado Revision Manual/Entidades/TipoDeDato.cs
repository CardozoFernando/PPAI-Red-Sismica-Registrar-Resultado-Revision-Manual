namespace PPAI_Red_Sismica_Registrar_Resultado_Revision_Manual.Entidades
{
    public class TipoDeDato
    {
        private string denominacion;
        private string nombreUnidadDeMedida;

        public TipoDeDato(string denominacion, string unidadDeMedida)
        {
            this.denominacion = denominacion;
            this.nombreUnidadDeMedida = unidadDeMedida;
        }

        public string Denominacion { get => denominacion; set => denominacion = value; }
        public string NombreUnidadDeMedida { get => nombreUnidadDeMedida; set => nombreUnidadDeMedida = value; }
    }
}
