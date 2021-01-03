using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Curriculums
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            ListaProfesores lp = new ListaProfesores();
            
            //

            if (File.Exists("Profesores.bin"))
            {
                using (Stream stream = File.Open("Profesores.bin", FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    lp = (ListaProfesores)bformatter.Deserialize(stream);

                }
            }
            else
            {
                ///datos de prueba
                lp.Add(new Profesor("100001", "Alex", "Gutierrez","Santillan", "holi"));
                lp.Add(new Profesor("100002", "juan", "Rodriguez","Martinez", "xd"));
                lp.contraseñaAdmin = "12345";
                //

                using (Stream sw = File.Open("Profesores.bin", FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    bformatter.Serialize(sw, lp);
                    sw.Close();
                }
            }
            //


            Form_Loging loging = new Form_Loging(lp,lp.contraseñaAdmin);
            loging.ShowDialog();


            File.Delete("Profesores.bin");
            using (Stream sw = File.Create("Profesores.bin"))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                bformatter.Serialize(sw, lp);
                sw.Close();

            }

        }
    }
}
