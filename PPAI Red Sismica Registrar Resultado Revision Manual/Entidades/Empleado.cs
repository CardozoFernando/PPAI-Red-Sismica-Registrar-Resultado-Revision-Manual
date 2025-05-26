namespace PPAI_Red_Sismica_Registrar_Resultado_Revision_Manual.Entidades
{
    public class Empleado
    {
        private string apellido;
        private string nombre;
        private string mail;
        private int telefono;

        public Empleado(string apellido, string nombre, string mail, int telefono)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.mail = mail;
            this.telefono = telefono;
        }

        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Mail { get => mail; set => mail = value; }
        public int Telefono { get => telefono; set => telefono = value; }
    }
}
