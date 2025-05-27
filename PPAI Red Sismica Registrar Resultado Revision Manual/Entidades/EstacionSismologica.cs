namespace PPAI_Red_Sismica_Registrar_Resultado_Revision_Manual.Entidades
{
    public class EstacionSismologica
    {
        private string nombre;

        public EstacionSismologica(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre() {
            return nombre;
        }

        public void setNombre(string nombre) {
            this.nombre = nombre;
        }   
    }

    
}
