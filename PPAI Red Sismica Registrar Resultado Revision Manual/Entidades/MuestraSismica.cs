using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Red_Sismica_Registrar_Resultado_Revision_Manual.Entidades
{
    public class MuestraSismica
    {
        private List<DetalleMuestra> detallesMuestra;
        private DateTime fechaHoraMuestra;
        public MuestraSismica(List<DetalleMuestra> detallesMuestra, DateTime fechaHoraMuestra)
        {
            this.detallesMuestra = detallesMuestra;
            this.fechaHoraMuestra = fechaHoraMuestra;
        }
        public List<DetalleMuestra> DetallesMuestra { get => detallesMuestra; set => detallesMuestra = value; }
        public DateTime FechaHoraMuestra { get => fechaHoraMuestra; set => fechaHoraMuestra = value; }
        public string getDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Fecha y hora de registro: " + fechaHoraMuestra);
            foreach (var detalle in detallesMuestra)
            {
                sb.AppendLine(detalle.getDatos());
            }
            return sb.ToString();
        }
    }
}
