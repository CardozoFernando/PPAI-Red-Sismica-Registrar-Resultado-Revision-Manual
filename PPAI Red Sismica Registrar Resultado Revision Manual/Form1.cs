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
//dialogResult dr = MessageBox.Show("�Desea Registrar Resultado de Revision Manual?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);