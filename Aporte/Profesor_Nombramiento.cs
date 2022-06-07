using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aporte
{
    class Profesor_Nombramiento : Profesor
    {

        private int sueldo;
        public Profesor_Nombramiento(string Nombres, string Apellidos, string Direccion, string Cedula, int sueldo) : base(Nombres, Apellidos, Direccion, Cedula)
        {

            this.sueldo = sueldo;
        }
        public void Fijo()
        {
            Console.WriteLine("El sueldo a recibir es de: " + sueldo);
        }
    }
}




