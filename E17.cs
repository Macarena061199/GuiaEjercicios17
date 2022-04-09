using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios17
{
    internal class E17
    {
        /* Solicite el ingreso de dos números al usuario y presente la suma, la resta, la multiplicación, 
         * la división, el resto, el primero elevado a la potencia del segundo.*/

        public void Ej17()
        {
            bool flag = false;
            do
            {
                Console.Write("Por favor ingrese un número: ");
                string ingresoA = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Por favor ingrese un número: ");
                string ingresoB = Console.ReadLine();

                flag = ValidarNumero(ingresoA, ingresoB);

                if (flag == true)
                {

                    int suma = Convert.ToInt32(ingresoA) + Convert.ToInt32(ingresoB);
                    int resta = Convert.ToInt32(ingresoA) - Convert.ToInt32(ingresoB);
                    int multiplicacion = Convert.ToInt32(ingresoA) * Convert.ToInt32(ingresoB);
                    int division = Convert.ToInt32(ingresoA) / Convert.ToInt32(ingresoB);
                    int resto = Convert.ToInt32(ingresoA) % Convert.ToInt32(ingresoB);
                    double potencia = Math.Pow(Convert.ToInt32(ingresoA), Convert.ToInt32(ingresoB));

                    Console.WriteLine($"La suma de {ingresoA} + {ingresoB} es {suma}.");
                    Console.WriteLine($"La resta de {ingresoA} - {ingresoB} es {resta}.");
                    Console.WriteLine($"La multiplicación de {ingresoA} * {ingresoB} es {multiplicacion}.");
                    Console.WriteLine($"La división de {ingresoA} / {ingresoB} es {division}.");
                    Console.WriteLine($"El resto de {ingresoA} % {ingresoB} es {resto}.");
                    Console.WriteLine($"La potencia de {ingresoA} ^ {ingresoB} es {potencia}.");
                }
            } while (flag == false);
            

        }

        private bool ValidarNumero(string A, string B)
        {
            bool flag = false;
            bool A1 = false;
            bool B1= false;
            if(!int.TryParse(A, out int salidaA))
            {
                Console.WriteLine("El valor ingresado debe ser un dato numérico. ");
            }
            else
            {
                A1 = true;
            }
            if(!int.TryParse(B, out int salidaB))
            {
                Console.WriteLine("El valor ingresado debe ser un dato numérico. ");
            }
            else
            {
                B1 = true;
            }
            if(A1==true && B1==true)
            {
                flag = true;
            }
            return flag;
        }


            
        
    }
}
