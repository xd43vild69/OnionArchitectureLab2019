namespace Dominio
{
    public class ClasificacionBovinos : IClasificacion
    {
        const string IDENTIFICADOR = "b";
        bool IClasificacion.Identificar(string animal)
        {
            bool clasifica = false;
            if (animal.ToLower().Contains(IDENTIFICADOR))
            {
                clasifica = true;
            }
            return clasifica; 
        }
    }

}

