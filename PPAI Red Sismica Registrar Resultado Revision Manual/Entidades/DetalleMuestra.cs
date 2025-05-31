using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Red_Sismica_Registrar_Resultado_Revision_Manual.Entidades
{
    public class DetalleMuestra
    {
        private double valor;
        private TipoDeDato tipoDeDato;

        public DetalleMuestra(double valor, TipoDeDato tipoDeDato)
        {
            this.valor = valor;
            this.tipoDeDato = tipoDeDato;
        }

        public double Valor { get => valor; set => valor = value; }
        public TipoDeDato TipoDeDato { get => tipoDeDato; set => tipoDeDato = value; }

        public List<object> getDatos() {
            List<object> datosSerieTemporal = new List<object>();
            datosSerieTemporal.Add(this.TipoDeDato.Denominacion);
            datosSerieTemporal.Add(this.TipoDeDato.NombreUnidadDeMedida);
            return datosSerieTemporal;
        }

    }
}
