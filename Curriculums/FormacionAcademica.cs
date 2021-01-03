using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculums
{
    [Serializable]
    public class FormacionAcademica
    {
        public String gradoAcademico { get; set; }
        public String nombre { get; set; }
        public String institucion { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public DateTime fechaObtención { get; set; }
        public String cedula { get; set; }


        public void ActualizarFormacionAcademica(String ga, String n, String i, DateTime fi, DateTime ff, DateTime fo, String c)
        {
            gradoAcademico = ga;
            nombre = n;
            institucion = i;
            fechaInicio = fi;
            fechaFin = ff;
            fechaObtención = fo;
            cedula = c;

        }
    }
}
