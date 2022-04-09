using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios17
{
    internal class E18
    {
        /*Solicite el ingreso de un número al usuario y lo presente redondeado a dos decimales.*/

        public void EJ18()
        {
            bool fla = false;
            do
            {
                Console.Write("Por favor ingrese un número: ");
                string ingresoA = Console.ReadLine();

                Console.WriteLine();
                decimal salida = 0;

                fla = ValidarNumero(ingresoA, ref salida);

                if(fla==true)
                {
                    salida = decimal.Round(salida, 2);

                    Console.WriteLine($"El número ingresado es: {salida}");
                }

            }while(fla==false);
        }

        private bool ValidarNumero(string A, ref decimal salida)
        {
            bool flag = false;
           
            if (!Decimal.TryParse(A, out salida))
            {
                Console.WriteLine("El valor ingresado debe ser un número decimal. ");
            }
            else
            {
                flag = true;
            }
            return flag;
        }

    }
}
