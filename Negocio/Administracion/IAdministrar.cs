using Entidades;
using System.Collections.Generic;

namespace Dominio
{
    public interface IAdministrar
    {
        void CrearListasClasificacionAnimales();
        List<Equino> obtenerEquinos();
        List<Bovino> obtenerBovinos();
    }
}
