using Entidades;
using System;
using System.IO;

namespace EntradaSalida
{
    public class LecturaDAT : ILectura
    {

        public IArchivo Archivo { get; set; }
        public string RutaArchivo { get; set; }

        public LecturaDAT(IArchivo archivo)
        {
            Archivo = archivo;            
        }

        public string[] LeerArchivo()
        {
            string[] archivo = File.ReadAllLines(Archivo.Ruta + Archivo.Nombre);
            return archivo;
        }

        public object Retornar()
        {
            throw new NotImplementedException();
        }
    }
}
