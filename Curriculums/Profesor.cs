using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Curriculums
{
    [Serializable]
    public class Profesor
    {
        
        public String codigo, nombre,apellidoP,apellidoM, domicilio, ciudad, email, contraseña,telefono;
        public List<Dependiente> listDependientes = new List<Dependiente>();
        public Image foto;
        public DateTime nacimiento = DateTime.Now.Date;

        ////////faltan datos XD
        //*/*//
        public List<FormacionAcademica> listaFormacion { get; set; }
        public List<ProduccionAcademica> listaProduccionA { get; set; }
        public List<Materia> listaMaterias { get; set; }
        public List<Tutorado> listaAlumnos { get; set; }

        //*/*//

        public Profesor(String codigo, String nombre ,String apellidoP,String apellidoM, String contraseña)
        {
            
            this.codigo = codigo;
            this.nombre = nombre;
            this.apellidoP = apellidoP;
            this.apellidoM = apellidoM;
            this.contraseña = contraseña;

            //*/*//
            listaFormacion = new List<FormacionAcademica>();
            listaProduccionA = new List<ProduccionAcademica>();
            listaMaterias = new List<Materia>();
            listaAlumnos = new List<Tutorado>();

            //*/*//
        }
    }
}
