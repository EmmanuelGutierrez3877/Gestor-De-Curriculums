using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using System.IO;



namespace Curriculums
{
    class Curriculum
    {
        public Curriculum(Profesor p, int opc)
        {
            Object oMissing = System.Reflection.Missing.Value;


            //Object oTemplatePath = "C:\\Users\\Usuario\\Desktop\\Ing Software\\Curriculums\\Curriculums\\bin\\Debug\\PlantillaWord.docx";
            if (!File.Exists(Application.StartupPath.ToString() + "\\PlantillaWord.docx"))
            {
                FileStream fileStream = new FileStream(Application.StartupPath.ToString() + "\\PlantillaWord.docx", FileMode.Create);
                foreach (byte b in Properties.Resources.PlantillaWord)
                {
                    fileStream.WriteByte(b);
                }
                fileStream.Close();
            }
            Object oTemplatePath = Application.StartupPath.ToString()+"\\PlantillaWord.docx";

           

            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = new Word.Document();

            if (opc == 1)
            {
                wordApp.Visible = true;
            }
            else
            {
                wordApp.Visible = false;
            }


            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);



            if (p.foto != null)
            {
                p.foto.Save("image.bmp");

                Word.InlineShape autoScaledInlineShape = wordDoc.InlineShapes.AddPicture(Application.StartupPath.ToString() + "\\image.bmp");
                File.Delete(Application.StartupPath.ToString() + "\\image.bmp");
            }
            

            ////
            foreach (Word.Field myMergeField in wordDoc.Fields)
            {


                Word.Range rngFieldCode = myMergeField.Code;

                String fieldText = rngFieldCode.Text;



                // ONLY GETTING THE MAILMERGE FIELDS

                if (fieldText.StartsWith(" MERGEFIELD"))
                {



                    Int32 endMerge = fieldText.IndexOf("\\");

                    Int32 fieldNameLength = fieldText.Length - endMerge;

                    String fieldName = fieldText.Substring(11, endMerge - 11);


                    fieldName = fieldName.Trim();


                    if (fieldName == "nombre")
                    {
                        myMergeField.Select();
                        if (p.foto==null)
                        {
                            wordApp.Selection.TypeText("\n\n\n\n " + p.apellidoP + " " + p.apellidoM + " " + p.nombre);
                        }
                        else
                        {
                            wordApp.Selection.TypeText("\n " + p.apellidoP + " " + p.apellidoM + " " + p.nombre);
                        }
                        
                    }
                    else if (fieldName == "direccion")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(p.domicilio);
                    }
                    else if (fieldName == "telefono")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(p.telefono);
                    }
                    else if (fieldName == "correo")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(p.email);
                    }
                    else if (fieldName == "ciudad")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(p.ciudad);
                    }
                    else if (fieldName == "TituloAcademica")
                    {
                        myMergeField.Select();
                        if (p.listaFormacion.Count != 0)
                        {

                            wordApp.Selection.TypeText("Formacion Academica");
                        }
                        else
                        {
                            wordApp.Selection.TypeText(" ");
                        }
                    }
                    else if (fieldName == "academica")
                    {
                        String fa = " ";
                        foreach (FormacionAcademica i in p.listaFormacion)
                        {
                            fa = fa + " - " + i.nombre + " | " + i.gradoAcademico + " | " + i.institucion +
                                        "\n\t\t inicio : " + i.fechaInicio.ToShortDateString() +
                                        "\n\t\t fin : " + i.fechaFin.ToShortDateString() +
                                        "\n\t\t Obtencion  :" + i.fechaObtención.ToShortDateString() + "\n";
                        }
                        myMergeField.Select();
                        wordApp.Selection.TypeText(fa);
                    }
                    else if (fieldName == "TituloProduccion")
                    {
                        myMergeField.Select();
                        if (p.listaProduccionA.Count != 0)
                        {

                            wordApp.Selection.TypeText("Produccion Academica");
                        }
                        else
                        {
                            wordApp.Selection.TypeText(" ");
                        }
                    }
                    else if (fieldName == "produccion")
                    {
                        String fa = " ";
                        foreach (ProduccionAcademica i in p.listaProduccionA)
                        {
                            String au = " ";
                            foreach (Autor a in i.listaAutores)
                            {
                                au = au + "\n\t\t" + a.apellidoP + " " + a.apellidoM + " " + a.nombre;
                            }

                            fa = fa + " - " + i.titulo + " | " + i.numeroRegistro + " | " + i.institucion + " | " + i.fecha.ToShortDateString() + au + "\n";
                        }
                        myMergeField.Select();
                        wordApp.Selection.TypeText(fa);
                    }

                    else if (fieldName == "TituloTutorados")
                    {
                        myMergeField.Select();
                        if (p.listaAlumnos.Count != 0)
                        {

                            wordApp.Selection.TypeText("Tutorados");
                        }
                        else
                        {
                            wordApp.Selection.TypeText(" ");
                        }
                    }
                    else if (fieldName == "tutorados")
                    {
                        String fa = " ";
                        foreach (Tutorado t in p.listaAlumnos)
                        {

                            fa = fa + " - " + t.nombre + " " + t.apaterno + " " + t.apaterno + " | " + t.codigo + " | De: " + t.fechaInicio.ToShortDateString() + " a: " + t.fechaFin.ToShortDateString() + "\n";
                        }
                        myMergeField.Select();
                        wordApp.Selection.TypeText(fa);
                    }
                }

            }


            

            if (opc==1)
            {
                wordDoc.SaveAs2(@Application.StartupPath.ToString()+"\\"+p.codigo+".docx");
            }
            else if (opc == 2)
            {
                wordDoc.SaveAs2(@Application.StartupPath.ToString() + "\\auxW.docx");
                abrirPDF(wordDoc, p);

                wordApp.Application.Quit();
            }
            else if (opc == 3)
            {
                wordDoc.SaveAs2(@Application.StartupPath.ToString() + "\\aux1.docx");
                crearImg(wordDoc, p);

                wordApp.Application.Quit();
            }

        }

        void abrirPDF(Word.Document wordDoc, Profesor p)
        {

            wordDoc.ExportAsFixedFormat(@Application.StartupPath.ToString() + "\\"+p.codigo+".pdf", Word.WdExportFormat.wdExportFormatPDF);

            string pdfPath = Path.Combine(@Application.StartupPath, wordDoc.FullName);

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = @Application.StartupPath.ToString() + "\\" + p.codigo + ".pdf";
            proc.Start();
            wordDoc.Close();


            File.Delete(@Application.StartupPath.ToString() + "\\auxW.docx");
        }

        void crearImg(Word.Document wordDoc, Profesor p)
        {

            wordDoc.ExportAsFixedFormat(@Application.StartupPath.ToString() + "\\aux1.pdf", Word.WdExportFormat.wdExportFormatPDF);

            wordDoc.Close();

            File.Delete(@Application.StartupPath.ToString() + "\\aux1.docx");
        }
         
        
        
    }

}
