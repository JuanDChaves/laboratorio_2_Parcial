using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_2_Parcial
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioResidencia;
        protected DateTime nacimiento;
        protected string nombre;

        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }

        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioResidencia) :this(nombre, apellido, nacimiento)
        {
            this.barrioResidencia = barrioResidencia;
        }

        protected string NombreCompleto { get => ToString(); }
        protected int Edad { get => DateTime.Today.AddTicks(- this.nacimiento.Ticks).Year - 1;  }

        public string ToString()
        {
            return $"{apellido} {nombre}";
        }

        public string FichaPersonal(Persona p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(ToString());
            sb.AppendLine(this.Edad.ToString());
            return sb.ToString();
        }

        internal abstract string FichaExtra();
 
    }
}
