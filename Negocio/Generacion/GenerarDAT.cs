using Negocio.Interfaces;
using System.Collections.Generic;

namespace Negocio.Generacion
{
    public class GenerarDAT : IGenerarArhivo
    {
        private IList<string> ListaNombres { get; set; }
        private string NombreArchivo { get; set; }
        private string RutaArchivo { get; set; }
        
        public GenerarDAT(IList<string> listaNombres, string rutaArchivo, string nombreArchivo)
        {
            ListaNombres = listaNombres;
            NombreArchivo = nombreArchivo;
            RutaArchivo = rutaArchivo;
        }

        public void GenerarArchivo()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(RutaArchivo + NombreArchivo))
            {
                foreach (string line in ListaNombres)
                {
                    // If the line doesn't contain the word 'Second', write the line to the file.
                    if (!line.Contains("b"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

        }
    }
}
