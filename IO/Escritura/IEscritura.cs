using Entidades;
using System.Collections.Generic;

namespace EntradaSalida
{
    public interface IEscritura
    {
        void EscribirArchivo(IList<IAnimal> listaAnimales, string nombre);
    }
}
