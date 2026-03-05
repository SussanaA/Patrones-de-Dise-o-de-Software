//Cliente

using AFactory;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////Menú
            //variable para la elección de la opción
            int op;

            //Switch para las diferentes opciones
            do
            {
                op = Opciones();
                switch (op)
                {
                    case 1:
                        modo(new PresencialFactory());
                        break;

                    case 2:
                        modo(new VirtualFactory());
                        break;

                    case 3:
                        modo(new HybridFactory());
                        break;

                    case 4:
                        Console.WriteLine("Cerrando programa\nPresione una tecla para salir");
                        //return;
                        Environment.Exit(0);

                        break;

                    default:
                        Console.WriteLine("Opción ingresada no válida");
                        break;
                }
            }while(op != 4);

            Console.ReadKey();
        }

        public static void modo(Factory factory)
        {
            //crear productos usando la fábrica
            Guide guide = factory.CreateGuide();
            Exam exam = factory.CreateExam();

            //usar a esos productos
            guide.ShowGuide();
            exam.ApplyExam();
        }


        //método que contiene las opciones
        public static int Opciones()
        {
            Console.WriteLine("\nModalidad de clase\n"
                +"1- Modalidad presencial\n"
                +"2- Modalidad en línea\n"
                +"3- Modalidad Híbrida\n"
                +"4- Cerrar\n"
                +"Seleccione una opción: \n"
             );

            int lee = int.Parse(Console.ReadLine());
            return lee;
        }
    }
}
