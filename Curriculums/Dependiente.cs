using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculums
{
    [Serializable]
    public class Dependiente
    {
        public String nombre,apellidoP,apellidoM;
        public DateTime nacimiento;

        public Dependiente(String nombre,String apellidoP, String apellidoM,DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellidoM = apellidoM;
            this.apellidoP = apellidoP;
            this.nacimiento = nacimiento;
        }

        public int getEdad()
        {
            int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
            return edad;
        }
    }
}
