using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aporte
{
    class Profesor
    {
        private string Nombres, Apellidos, Direccion, Cedula;
        public Profesor(string Nombres, string Apellidos, string Direccion, string Cedula)
        {

            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Direccion = Direccion;
            this.Cedula = Cedula;
        }
        public void imprimirDatos()
        {

            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Cedula: " + Cedula);
            Console.WriteLine("Direccion: " + Direccion);

        }
    }
}
