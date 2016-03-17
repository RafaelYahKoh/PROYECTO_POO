using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ProyectoProgramacion
{
    class main:cuadros
    {
        public void title() {
            int x = 16;
            Console.SetCursorPosition(x,5);
            Console.WriteLine("╦  ╔═╗╔╗ ╔═╗╦═╗╔═╗╔╦╗╔═╗╦═╗╦ ╦  ╔═╗╦ ╦╔═╗╔╦╗╔═╗╔╦╗");
            Console.SetCursorPosition(x, 6);
            Console.WriteLine("║  ╠═╣╠╩╗║ ║╠╦╝╠═╣ ║ ║ ║╠╦╝╚╦╝  ╚═╗╚╦╝╚═╗ ║ ║╣ ║║║");
            Console.SetCursorPosition(x, 7);
            Console.WriteLine("╩═╝╩ ╩╚═╝╚═╝╩╚═╩ ╩ ╩ ╚═╝╩╚═ ╩   ╚═╝ ╩ ╚═╝ ╩ ╚═╝╩ ╩");
        }
        public main()
        {
            ConsoleKeyInfo op;
           
            do
            {
                Console.SetWindowSize(81, 30);
                Console.BufferHeight = Console.WindowHeight;
                Console.BufferWidth = Console.WindowWidth;
                marco();
                Console.BackgroundColor = ConsoleColor.Black;
                title();
                //Height: ancho
                //Width: Largo
                //x = posicion en x
                //Y = posicion en y
                //CUADRO DE ALUMNO;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                cuadro(5, 20, 7, 10);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(11, 12);
                Console.WriteLine("   ALUMNO   ");
                line(9, 12, 13);
                //CUADRO DE ADMINISTRADOR
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                cuadro(5, 21, 31, 10);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(32, 12);
                Console.WriteLine("   ADMINISTRADOR  ");
                line(15, 34, 13);


                //CUADRO DE REGISTRO
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                cuadro(5, 20, 55, 10);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(57, 12);
                Console.WriteLine(" REGISTRO ALUMNO ");
                line(17, 57, 13);


                //CUADRO DE AVISO
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                cuadro(8, 68, 7, 18);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(39, 19);
                Console.WriteLine("AVISOS");
                StreamReader arhivo = new StreamReader("C:\\Windows\\Temp\\BD\\aviso.txt");
                int con = 0;
                while (true)
                {
                    string line = arhivo.ReadLine();
                    Console.SetCursorPosition(9, 21 + con);
                    Console.WriteLine(line);
                    if (line == null)
                    {
                        break;
                    }
                    con++;
                }
                arhivo.Close();
                //Pide una tecla y si presiona escape se cierra la ventana
                op = Console.ReadKey();
            } while (op.Key != ConsoleKey.Escape);
        }
    }
}
