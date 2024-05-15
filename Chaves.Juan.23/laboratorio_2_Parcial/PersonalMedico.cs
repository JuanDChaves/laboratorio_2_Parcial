using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_2_Parcial
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esResidente) : base(nombre, apellido, nacimiento)
        {
            this.esResidente = esResidente;
        }

       // public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        //{
        //    return Consulta consulta;
        //}

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Finalizo Residencia: {(esResidente ? "Si" : "No")}");
            sb.AppendLine("ATENCIONES:");
            //consultas.ForEach(item in consultas) {
            //   sb.AppendLine();
            //}

            return sb.ToString();
        }
    }
}
