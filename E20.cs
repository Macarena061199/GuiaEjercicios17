using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios17
{
    internal class E20
    {
        /*Solicite el ingreso de 2 números al usuario y determine el mayor.*/

        public void Ej20()
        {
            bool flag = false;
            int numeroA=0;
            int numeroB=0;
            do
            {
                Console.Write("Por favor ingrese un número: ");
                string ingresoA = Console.ReadLine();

                Console.WriteLine();

                flag= ValidarNumero(ingresoA);

                if(flag==true)
                {
                   numeroA = Convert.ToInt32(ingresoA);
                }
                
            } while (flag == false);

            flag = false;

            do
            {
                Console.Write("Por favor ingrese un número: ");
                string ingresoB = Console.ReadLine();

                Console.WriteLine();

                flag = ValidarNumero(ingresoB);

                if (flag == true)
                {
                    numeroB = Convert.ToInt32(ingresoB);
                }


            } while (flag == false);

            

            if(numeroA>numeroB)
            {
                Console.WriteLine($"El número {numeroA} es mayor que {numeroB}");
            }
            else if (numeroA < numeroB)
            {
                Console.WriteLine($"El número {numeroB} es mayor que {numeroA}");
            }
            else
            {
                Console.WriteLine($"El número {numeroB} es igual que {numeroA}");
            }
        }

        private bool ValidarNumero(string A)
        {
            bool flag = false;
            
            if (!int.TryParse(A, out int salidaA))
            {
                Console.WriteLine("El valor ingresado debe ser un dato numérico. ");
            }
            else
            { 
                flag = true;
            }
            return flag;
        }
    }
}
