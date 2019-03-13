using Autofac;
using Entidades;
using EntradaSalida;
using Dominio;

namespace IOC
{
    public static class ConfiguracionIoC
    {
        private static IContainer Container { get; set; }
        public static T GetInstance<T>()
        {
            return Container.Resolve<T>();           
        }
        
        public static void RegistrarIoC(IArchivo archivo)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<LecturaDAT>().As<ILectura>().WithParameter("archivo", archivo);
            builder.RegisterType<EscrituraTXT>().As<IEscritura>().WithParameter("archivo", archivo);
            Container = builder.Build();            
        }

    }
}
