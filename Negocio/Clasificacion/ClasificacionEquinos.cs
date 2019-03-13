namespace Dominio
{
    public class ClasificacionEquinos : IClasificacion
    {
        const string IDENTIFICADOR = "b";

        bool IClasificacion.Identificar(string animal)
        {
            return true;
        }
    }
}
