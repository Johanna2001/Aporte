using System;

namespace Aporte
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    {
                        Console.WriteLine("Estudiantes");
                        Profesor_horas Profesor_Horas = new Profesor_horas("Maria", "Zambrano", "Los Esteros", "1312145122", 5, 70);
                        Profesor_Horas.Valor();
                        Profesor_Horas.imprimirDatos();
                        Console.WriteLine(" ");
                        Console.WriteLine("__________________________");
                        Console.WriteLine(" ");
                        Profesor_Contrato Profesor_contrato = new Profesor_Contrato("Carlos", "Parrales", "Montecristi", "12314526455", 480, 25, 10);
                        Profesor_contrato.Calcular();
                        Profesor_contrato.imprimirDatos();
                        Console.WriteLine(" ");
                        Console.WriteLine("_________________________________");
                        Console.WriteLine(" ");
                        Profesor_Nombramiento Profesor_nombramiento = new Profesor_Nombramiento("Pedro", "Pin", "ULEAM", "1234521244", 1320);
                        Profesor_nombramiento.Fijo();
                        Profesor_nombramiento.imprimirDatos();
                    }
                }
            }
        }
    }
}
