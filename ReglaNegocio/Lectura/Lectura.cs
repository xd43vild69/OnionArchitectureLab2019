using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ReglaNegocio.Lectura
{
    public class Lectura : Interfaces.ILectura
    {

        public string NombreArchivo { get; set; }
        public string RutaArchivo { get; set; }

        public Lectura(string nombreArchivo, string rutaArchivo)
        {
            NombreArchivo = nombreArchivo;
            RutaArchivo = rutaArchivo;
        }

        public void Buscar()
        {

            string[] text = File.ReadAllLines(@"D:\test\EQUNOSBOVINOS.DAT");

            string[] text2 = File.ReadAllLines(RutaArchivo + NombreArchivo);

            foreach (string line in text)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }
        }

        public object Retornar()
        {
            throw new NotImplementedException();
        }
    }
}
