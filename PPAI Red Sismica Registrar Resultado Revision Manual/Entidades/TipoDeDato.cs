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

        public string Denominacion { get => denominacion; set => denominacion = value; }
        public string UnidadDeMedida { get => unidadDeMedida; set => unidadDeMedida = value; }
