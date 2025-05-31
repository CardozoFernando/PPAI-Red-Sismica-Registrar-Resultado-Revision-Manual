using PPAI_Red_Sismica_Registrar_Resultado_Revision_Manual.Entidades;
using System.Text;

namespace PPAI_Red_Sismica_Registrar_Resultado_Revision_Manual
{
    public partial class VentanaRedSismica : Form
    {
        public VentanaRedSismica()
        {
            InitializeComponent();
        }

        private void BtnRegResRevMan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo");
            // Abajo se muestra un ejemplo de cómo generar y mostrar una lista de estaciones sismológicas.
            /*datos.Datos datos = new datos.Datos();

            EstacionSismologica[] estaciones = datos.generadorEstacionesSismologicas();
            StringBuilder sb = new StringBuilder();
            foreach (EstacionSismologica estacion in estaciones)
            {
                sb.AppendLine(estacion.Nombre);
            }
            MessageBox.Show(sb.ToString(), "Estaciones Sismológicas");*/
        }

        private void VentanaRedSismica_Load(object sender, EventArgs e)
        {

        }
    }
}
//if txtNombre.Text.Equals("")
//  {
//      MessageBox("Debe completar el campo")
//  }
//dialogResult dr = MessageBox.Show("¿Desea Registrar Resultado de Revision Manual?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);