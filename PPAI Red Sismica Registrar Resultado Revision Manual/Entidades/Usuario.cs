using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Red_Sismica_Registrar_Resultado_Revision_Manual.Entidades
{
    public class Usuario
    {
        private string nombreUsuario;
        private Empleado empleado;

        public Usuario(string nombreUsuario, Empleado empleado)
        {
            this.NombreUsuario = nombreUsuario;
            this.Empleado = empleado;
        }

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public Empleado Empleado { get => empleado; set => empleado = value; }
    }
}
