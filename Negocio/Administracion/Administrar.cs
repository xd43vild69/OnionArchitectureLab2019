using Entidades;
using System.Collections.Generic;

namespace Dominio
{
    public class Administrar
    {
        private IClasificacion clasificacionBovinos;
        private IClasificacion clasificacionEquinos;
        private List<IAnimal> equinosLista;
        private List<IAnimal> bovinosLista;
        private string[] animales;

        public List<IAnimal> ObtenerEquinos()
        {
            return equinosLista;
        }

        public List<IAnimal> ObtenerBovinos()
        {
            return bovinosLista;
        }

        public Administrar(string[] animales, IClasificacion clasificacionBovinos, IClasificacion clasificacionEquinos)
        {
            this.animales = animales;
            this.clasificacionBovinos = clasificacionBovinos;
            this.clasificacionEquinos = clasificacionEquinos;
            equinosLista = new List<IAnimal>();
            bovinosLista = new List<IAnimal>();
        }

        public void CrearListasClasificacionAnimales()
        {
            foreach (string animal in animales)
            {
                if (clasificacionBovinos.Identificar(animal))
                {
                    Bovino bovino = new Bovino { Nombre = animal };
                    bovinosLista.Add(bovino);
                }else if (clasificacionEquinos.Identificar(animal))
                {
                    Equino equino = new Equino { Nombre = animal };
                    equinosLista.Add(equino);
                }
            }
        }
    }
}
