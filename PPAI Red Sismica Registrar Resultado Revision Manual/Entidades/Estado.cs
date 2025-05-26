namespace PPAI_Red_Sismica_Registrar_Resultado_Revision_Manual.Entidades
{
    public class Estado
    {
        private string ambito;
        private string nombreEstado;

        public Estado(string ambito, string nombreEstado)
        {
            this.ambito = ambito;
            this.nombreEstado = nombreEstado;
        }

        public string Ambito { get => ambito; set => ambito = value; }
        public string NombreEstado { get => nombreEstado; set => nombreEstado = value; }
    }
}
