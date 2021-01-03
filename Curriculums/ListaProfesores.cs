using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculums
{
    [Serializable]
    public class ListaProfesores : List<Profesor>
    {
        public String contraseñaAdmin;
    }
}
