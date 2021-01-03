using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculums
{
    [Serializable]
    public class ProduccionAcademica
    {
        public string categoria { get; set; }
        public string titulo { get; set; }
        public DateTime fecha { get; set; }
        public string institucion { get; set; }
        public string numeroRegistro { get; set; }
        public List<Autor> listaAutores { get; set; }

        public ProduccionAcademica()
        {
            listaAutores = new List<Autor>();
        }
        public void actualizarDatos(string c, string t, DateTime f, string i, string n)
        {
            this.categoria = c;
            this.titulo = t;
            this.fecha = f;
            this.institucion = i;
            this.numeroRegistro = n;
        }
    }
}
