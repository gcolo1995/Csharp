using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColombanoGabrielProg1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[,] Autos = new string[,] {{"Ford", "Focus", "2018", "AB254DR", "42500", "4900000" },
                                             {"Chevrolet", "Prisma","2019","AC147HY", "35000", "5200000" },
                                             {"Renault", "Fluence", "2016", "AA236DE", "95000", "2600000" },
                                             {"Fiat", "Cronos", "2020", "AD863JE", "10000", "4500000" },
                                             {"VW", "Vento", "2017", "AB623FD", "65000", "5600000" },
                                             {"Citroen", "C4 Louge", "2018", "AC419WS", "90000", "4200000" } };
            int autoElegido = 0;            //guarda la fila del auto elegido
            int[] Pago = new int[6];        //guarda total del auto, contado y financiado, cant cuotas e interes     



            autoElegido = compra(Autos);        //muestra los modelos y el cliente elige
            Pago[0] = autoElegido;
            Pago[1] = int.Parse(Autos[autoElegido,5]);
            contadoYFinanciado(Pago);    //trae el valor del auto y le cliente indica cuanto paga de contado
            cantCuotasElegidas(Pago);                       //trae el monto a financiar y guarda la cant de cuotas e interes
            muestraEleccion(Autos, Pago);

            Console.ReadKey();


        }

        static int compra(string[,] Autos)
        {
            int elegido = 0;
            Console.WriteLine("\t \t Marca \t Modelo \t Año \t Patente \t Kilometros \t Valor");

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Opción {i + 1} \t {Autos[i, 0]} \t {Autos[i, 1]} \t {Autos[i, 2]} " +
                                  $"\t {Autos[i, 3]} \t {Autos[i, 4]} \t $ {Autos[i, 5]} .\n");

            }

            do
            {
                Console.Write("Ingrese el número de vehículo elegido: ");
                elegido = (int.Parse(Console.ReadLine()) - 1);         //como arranca del 1, debo restar uno para la fila correcta
            } while (!(elegido >= 0 && elegido <= 5));

            Console.WriteLine($"Elegiste el {Autos[elegido,0]} {Autos[elegido,1]} que cuesta ${Autos[elegido,5]}");

            return elegido;
        }

        static void contadoYFinanciado(int[] Pago)
        {
            int contado=0;

            do
            {
                Console.Write($"De los $ {Pago[1]} , ¿cuánto cancelará de contado? ");
                contado = (int.Parse(Console.ReadLine()));        
            } while (!(contado >= 0 && contado <= Pago[1]));

            Pago[2] = contado;
            Pago[3] = (Pago[1] - contado);

            Console.WriteLine($"Le quedará por financiar: $ {Pago[3]} .");

        }

        static void cantCuotasElegidas(int[] Pago)
        {
            int cantCuotas = 0;
            Console.WriteLine("Las opciones de financiamiento son 4: \n \t ");
            for(int i = 1; i < 5; i++)
            {
                Console.WriteLine($"\t Opción {i} \t{i * 12} cuotas con un interés del {i * 30} % \n");
            }

            do
            {
                Console.Write("¿Cuál de las opciones eliges? Opción ");
                cantCuotas = (int.Parse(Console.ReadLine()));         //como arranca del 1, debo restar uno para la fila correcta
            } while (!(cantCuotas >= 1 && cantCuotas <= 4));

            Pago[4] = cantCuotas*12;
            Pago[5] = cantCuotas * 30;

            Console.WriteLine($"El monto financiado, con el {Pago[5]}% de interés quedaría en $ {((Pago[3] * Pago[5]) / 100) + Pago[3]} " +
                              $"a pagar en {Pago[4]} cuotas.");
        }

        static void muestraEleccion(string[,] Autos,int[] Pago)
        {
            double valorCuota = (((Pago[3] * Pago[5]) / 100) + Pago[3]) / Pago[4];

            Console.WriteLine($"Para finalizar, muestro los datos elegidos por usted:\n" +
                              $"\t{Autos[Pago[0], 0]} {Autos[Pago[0], 1]}, año {Autos[Pago[0], 2]} " +
                              $"patente {Autos[Pago[0], 3]}, con {Autos[Pago[0], 4]} kilometros,\n\ta pagar  ${Pago[2]} de contado, " +
                              $"y el resto en {Pago[4]} cuotas de $ {valorCuota} fijas. \nMuchas gracias por confiar en nosotros");

        }
    }
}
