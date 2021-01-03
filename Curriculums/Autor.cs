using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculums
{
    [Serializable]
    public class Autor
    {
        public String nombre, apellidoP, apellidoM;

        public Autor(String nombre, String apellidoP, String apellidoM)
        {
            this.nombre = nombre;
            this.apellidoM = apellidoM;
            this.apellidoP = apellidoP;
        }
        public Autor()
        {

        }
    }
}
