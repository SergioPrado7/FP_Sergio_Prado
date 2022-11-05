using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FPU3C_Ejercicio1_Sergio_Prado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Personalizando la consola
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //Declarando datos
            string name, lastName, contactNumber, city, FBPerfil, email;
            string nameUser, password, confirmPassword, codeAccess;
            byte age = 0;

            //Utilizando los datos antes del If
            Console.WriteLine("DEBES LLENAR ESTE FORMULARIO DE REGISTRO \t (Al finalizar de escribir o digitar presiona la tecla ENTER)");
            Console.WriteLine("\n");
            Console.WriteLine("Ingresa tu nombre:");
            name = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido:");
            lastName = Console.ReadLine();
            Console.WriteLine("Ingrese su edad: \t (Solo digitos)");
            age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("\n");

            //Utilizando If
            if (age >= 18)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                //Utilizando los datos declarados
                Console.WriteLine("MUY BIEN SIGAMOS CON EL FORMULARIO DE REGISTRO");
                Console.WriteLine("\n");
                Console.WriteLine("Ingrese su número de teléfono: \t (Solo digitos)");
                contactNumber = Console.ReadLine();
                Console.WriteLine("Ingrese su ciudad:");
                city = Console.ReadLine();
                Console.WriteLine("Ingrese su perfil de Facebook:");
                FBPerfil = Console.ReadLine();
                Console.WriteLine("Ingrese su correo electrónico:");
                email = Console.ReadLine();
                Console.WriteLine("\n");
                Console.WriteLine("Ingrese un nombre de usuario:");
                nameUser = Console.ReadLine();
                Console.WriteLine("Ingrese una contraseña:");
                password = Console.ReadLine();
                Console.WriteLine("Ingrese nuevamente la contraseña:");
                confirmPassword = Console.ReadLine();
                Console.WriteLine("\n");

                //Utilizando If dentro de un If
                if (password == confirmPassword)
                {
                    //Números aleatorios
                    Random rnd = new Random();
                    codeAccess = rnd.Next(1000, 9999).ToString();
                    Console.WriteLine("Su clave de acceso es: {0} \t", codeAccess);
                    Console.WriteLine("\n");
                }
            }
            else 
            {
                Console.WriteLine("Lo sentimos tienes que ser mayor de edad para poder registrarse");
                Console.WriteLine("\n");
            }

            Console.WriteLine("Saliendo de la consola.");
            Thread.Sleep(2000);
            Console.WriteLine("Saliendo de la consola..");
            Thread.Sleep(2000);
            Console.WriteLine("Saliendo de la consola...");
            Thread.Sleep(2000);
        }
    }
}
