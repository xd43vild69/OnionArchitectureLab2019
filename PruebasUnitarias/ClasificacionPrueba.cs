using Entidades;
using EntradaSalida;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PruebasUnitarias
{
    /// <summary>
    /// Llamado básico para cubrimiento de código con algunas pruebas unitarias.
    /// </summary>
    [TestClass]
    public class ClasificacionPrueba
    {
        private const string RUTA = @"D:\test\";
        private const string NOMBRE = "EQUNOSBOVINOS.DAT";

        [TestMethod]
        public void LeerArchivoPrueba()
        {
            IArchivo archivo = new Archivo();
            archivo.Ruta = RUTA;
            archivo.Nombre = NOMBRE;

            LecturaDAT lectura = new LecturaDAT(archivo);
            lectura.LeerArchivo();
            // assert que el archivo fue exitosamente leido.
        }

        [TestMethod]
        public void ClasificarArchivoPrueba()
        {
            string[] animales = File.ReadAllLines(RUTA + NOMBRE);
            IClasificacion clasificacionEquinos = new ClasificacionEquinos();
            IClasificacion clasificacionBovinos = new ClasificacionBovinos();
            Administrar administrar = new Administrar(animales, clasificacionBovinos, clasificacionEquinos);
            administrar.CrearListasClasificacionAnimales();
            List<IAnimal> animalLista = administrar.ObtenerBovinos();
            
            if(animalLista.Count > 0)
            {
                Assert.IsTrue((from l in animalLista select l).FirstOrDefault().Nombre.ToLower().Contains("b"));
            }
        }

        [TestMethod]
        public void GenerarArchivoPrueba()
        {           

            IArchivo archivo = new Archivo();
            archivo.Ruta = RUTA;
            archivo.Nombre = NOMBRE;

            IList<IAnimal> listaAnimales = new List<IAnimal>();
            Bovino bovino = new Bovino();
            bovino.Nombre = "bisontes";
            listaAnimales.Add(bovino);
            bovino = new Bovino();
            bovino.Nombre = "Asno";
            listaAnimales.Add(bovino);

            IEscritura escrituraTXT = new EscrituraTXT(archivo);
            escrituraTXT.EscribirArchivo(listaAnimales,archivo.Nombre );
        }
    }
}
