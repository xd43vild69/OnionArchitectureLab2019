using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Negocio.Lectura
{
    public class LecturaArhivoPlano : Interfaces.ILectura
    {

        public string NombreArchivo { get; set; }
        public string RutaArchivo { get; set; }

        public LecturaArhivoPlano(string rutaArchivo, string nombreArchivo)
        {
            NombreArchivo = nombreArchivo;
            RutaArchivo = rutaArchivo;
        }

        public void Leer()
        {

            //string[] text = File.ReadAllLines(@"D:\test\EQUNOSBOVINOS.DAT");

            string[] archivo = File.ReadAllLines(RutaArchivo + NombreArchivo);

            foreach (string linea in archivo)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + linea);
            }
        }

        public object Retornar()
        {
            throw new NotImplementedException();
        }
    }
}
