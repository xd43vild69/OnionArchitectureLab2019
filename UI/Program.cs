using Entidades;
using Servicios;
using System;
using System.IO;

namespace UI
{
    class Program
    {

        /// <summary>
        /// Metodo principal UI desde donde es realizado el llamado a la logica de clasificación de Bovinos y Equinos.
        /// Desarrollo con estructura basica para prueba de XpertGroup
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IArchivo archivo = new Archivo();
            archivo.Ruta = @"D:\test\";
            archivo.Nombre = "EQUNOSBOVINOS.DAT";

            try
            {

                Console.WriteLine("Prueba por David Gómez para XpertGroup");

                AnimalesServicio clasificacionAnimales = new AnimalesServicio(archivo);
                clasificacionAnimales.SepararAnimales();

                Console.WriteLine("...");
                Console.Read();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No se pudo encontrar el archivo.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error: {ex.Message}"); 
            }
        }
    }
}
