using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial1.Poullion.Models
{
    public class GestorConstelacion
    {
        private static List<Constelacion> constelaciones = new List<Constelacion>();

        public static void InitLista()
        {
            constelaciones.Add(new Constelacion { Siglo = "19", Nombre="Prueba" });

        }

        public static List<Constelacion> GetConstelaciones()
        {
            return constelaciones;

        }

        public static void Add(Constelacion constelacion )
        {
            constelaciones.Add(constelacion);
        }
    }
}