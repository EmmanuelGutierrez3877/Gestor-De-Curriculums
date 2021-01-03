using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculums
{
    [Serializable]
    public class Tutorado
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string apaterno { get; set; }
        public string amaterno { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public string horas { get; set; }

        public void actualizarDatos(string c, string n, string ap, string am, string h, DateTime i, DateTime f )
        {
            codigo = c;
            nombre = n;
            apaterno = ap;
            amaterno = am;
            fechaInicio = i;
            fechaFin = f;
            horas = h;
        }
    }
}
