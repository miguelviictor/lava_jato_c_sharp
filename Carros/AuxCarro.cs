using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros
{
    public static class AuxCarro
    {
        private static Carros carros;

        static AuxCarro()
        {
            Carros = new Carros();
        }

        internal static Carros Carros { get => carros; set => carros = value; }
    }
}
