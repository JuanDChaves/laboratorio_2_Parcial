using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_2_Parcial
{
    public class Consulta
    {
        private DateTime fecha;
        private Paciente paciente;

        public DateTime Fecha { get => fecha; }
        public Paciente Paciente { get => paciente; }

        public Consulta(DateTime fecha, Paciente paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }

        public string ToString()
        {
            return $"{fecha} se ha atendido a {paciente.FichaPersonal}";
        }
    }
}
