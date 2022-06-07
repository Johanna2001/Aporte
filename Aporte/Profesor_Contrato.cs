using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aporte
{
    class Profesor_Contrato: Profesor
    {
        private int sueldo;
        private int horas;
        private int Valor;
        private int total;
        private int Suma;
        public Profesor_Contrato(string Nombres, string Apellidos, string Direccion, string Cedula, int sueldo, int horas, int Valor) : base(Nombres, Apellidos, Direccion, Cedula)
        {

            this.sueldo = sueldo;
            this.horas = horas;
            this.Valor = Valor;
            total = horas * Valor;
            Suma = total + sueldo;
        }
        public void Calcular()
        {
            Console.WriteLine("El sueldo a recibir es de: " + Suma);
        }
    }
}


