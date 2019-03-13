using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Archivo: IArchivo
    {
        public string Nombre { get; set; }
        public string Ruta { get; set; }
    }
}
