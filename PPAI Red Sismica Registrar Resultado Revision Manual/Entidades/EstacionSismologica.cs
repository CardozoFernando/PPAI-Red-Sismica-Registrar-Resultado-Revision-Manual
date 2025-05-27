namespace PPAI_Red_Sismica_Registrar_Resultado_Revision_Manual.Entidades
{
    public class EstacionSismologica
    {
        private string nombre;

        public EstacionSismologica(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
    }
}