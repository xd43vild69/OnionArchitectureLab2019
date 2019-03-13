using Entidades;
using System.Collections.Generic;

namespace EntradaSalida
{
    public class EscrituraTXT : IEscritura
    {
        private IList<IAnimal> listaAnimales { get; set; }
        private IArchivo archivo { get; set; }
        private string RutaArchivo { get; set; }

        public EscrituraTXT(IArchivo archivo)
        {
            this.listaAnimales = listaAnimales;
            this.archivo = archivo;         
        }
        
        void IEscritura.EscribirArchivo(IList<IAnimal> listaAnimales, string nombre)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(archivo.Ruta + nombre))
            {
                foreach (IAnimal animal in listaAnimales)
                {
                    file.WriteLine(animal.Nombre);
                }
                System.Console.WriteLine($"Se crea un archivo ${archivo.Nombre} en :{archivo.Ruta}.");
            }
        }
    }
}
