using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculums
{
    [Serializable]
    public class Materia
    {
        public string nombre;
        public DateTime inicio;
        public DateTime fin;
        public string programa;
        public string cargahoraria;

        public void actualizarDatos(string n, DateTime i, DateTime f, string p, string ch)
        {
            this.nombre = n;
            this.inicio = i;
            this.fin = f;
            this.programa = p;
            this.cargahoraria = ch;
        }
    }
}
