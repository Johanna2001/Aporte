using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aporte
{
    class Profesor_horas: Profesor
    {
        private int valor;
        private int horas;
        private int total;
        public Profesor_horas(string Nombres, string Apellidos, string Direccion, string Cedula, int valor, int horas) : base(Nombres, Apellidos, Direccion, Cedula)
        {

            this.valor = valor;
            this.horas = horas;
            total = horas * valor;
        }
        public void Valor()
        {
            Console.WriteLine("El sueldo a recibir es de: " + total);
        }
    }
}