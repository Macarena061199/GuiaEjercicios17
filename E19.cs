using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios17
{
    internal class E19
    {
        /* Solicite el ingreso de un número al usuario y presente la parte entera. */

        public void Ej19()
        {
            bool flag = false;
            do
            {
                Console.Write("Por favor ingrese un número: ");
                string ingresoA = Console.ReadLine();

                Console.WriteLine();

                int salida =0;

                flag = ValidarNumero(ingresoA, ref salida);

                if(flag==true)
                {
                    Console.WriteLine($"Usted ingreso el número: {ingresoA}.");
                    Console.WriteLine($"La parte entera del número ingresado es: {salida}");
                }

            }while(flag==false);

        }

        private bool ValidarNumero(string A, ref int salida)
        {
            bool flag = false;
 
            if (!Decimal.TryParse(A, out decimal salida1))
            {
                Console.WriteLine("El valor ingresado debe ser un dato numérico. ");
            }
            else
            {
                salida = int.Parse(A.Split('.')[0]);
                flag = true;
            }
            return flag;
        }
    }   
}
