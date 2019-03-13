using Entidades;
using EntradaSalida;
using Dominio;
using IOC;

namespace Servicios
{
    public class AnimalesServicio
    {
        private const string EQUINO = "Equino.txt";
        private const string BOVINO = "Bovino.txt";
        private IArchivo archivo { get; set; }
        private IArchivo archivoSalida { get; set; }

        public AnimalesServicio(IArchivo archivo)
        {
            this.archivo = archivo;
            archivoSalida = new Archivo();
            archivoSalida.Ruta = archivo.Ruta;
            ConfiguracionIoC.RegistrarIoC(archivo);
        }

        public void SepararAnimales()
        {
            ILectura lecturaDAT = ConfiguracionIoC.GetInstance<ILectura>();
            string[] animales = lecturaDAT.LeerArchivo();

            IClasificacion clasificacionEquinos = new ClasificacionEquinos();
            IClasificacion clasificacionBovinos = new ClasificacionBovinos();

            Administrar administrar = new Administrar(animales, clasificacionBovinos, clasificacionEquinos);
            administrar.CrearListasClasificacionAnimales();

            IEscritura escrituraTXT = ConfiguracionIoC.GetInstance<IEscritura>();
            escrituraTXT.EscribirArchivo(administrar.ObtenerBovinos(), BOVINO);
            escrituraTXT.EscribirArchivo(administrar.ObtenerEquinos(), EQUINO);
        }
    }
}
