using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace ProyectoProgramacion
{
    class main : cuadros
    {
        public void title()
        {
            int x = 16;
            Console.SetCursorPosition(x, 5);
            Console.WriteLine("╦  ╔═╗╔╗ ╔═╗╦═╗╔═╗╔╦╗╔═╗╦═╗╦ ╦  ╔═╗╦ ╦╔═╗╔╦╗╔═╗╔╦╗");
            Console.SetCursorPosition(x, 6);
            Console.WriteLine("║  ╠═╣╠╩╗║ ║╠╦╝╠═╣ ║ ║ ║╠╦╝╚╦╝  ╚═╗╚╦╝╚═╗ ║ ║╣ ║║║");
            Console.SetCursorPosition(x, 7);
            Console.WriteLine("╩═╝╩ ╩╚═╝╚═╝╩╚═╩ ╩ ╩ ╚═╝╩╚═ ╩   ╚═╝ ╩ ╚═╝ ╩ ╚═╝╩ ╩");
        }
        public void opciones(int k = 0)
        {
           
                ConsoleColor cc = ConsoleColor.DarkGreen;
                ConsoleColor sel = ConsoleColor.White;

                //Height: ancho
                //Width: Largo
                //x = posicion en x
                //Y = posicion en y

                //CUADRO DE ALUMNO;
                Console.ForegroundColor = k == 0 ? sel : cc;
                cuadro(5, 20, 7, 10);
                Console.SetCursorPosition(11, 12);
                Console.BackgroundColor = k == 0 ? sel :cc ; 
                Console.ForegroundColor = k == 0 ? cc : sel;
                Console.WriteLine("   ALUMNO   ");
                Console.ForegroundColor = k == 0 ? cc : sel;
                line(9, 12, 13);

                //CUADRO DE ADMINISTRADOR
                Console.ForegroundColor = k == 1 ? sel : cc;
                cuadro(5, 21, 31, 10);
                Console.SetCursorPosition(32, 12);
                Console.BackgroundColor = k == 1 ? sel : cc;
                Console.ForegroundColor = k == 1 ? cc : sel;
                Console.WriteLine("   ADMINISTRADOR  ");
                Console.ForegroundColor = k == 1 ? cc : sel;
                line(15, 34, 13);

                //CUADRO DE REGISTRO
                Console.ForegroundColor = k == 2 ? sel : cc;
                cuadro(5, 20, 55, 10);
                Console.SetCursorPosition(57, 12);
                Console.BackgroundColor = k == 2 ? sel : cc;
                Console.ForegroundColor = k == 2 ? cc : sel;
                Console.WriteLine(" REGISTRO ALUMNO ");
                Console.ForegroundColor = k == 2 ? cc : sel;
                line(17, 57, 13);
            
        }
        public void Menu()
        {
            //CONFIGURACION DE LA VENTANA
            Console.SetWindowSize(81, 30);
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            marco();
            Console.BackgroundColor = ConsoleColor.Black;
            title();
            
            //TERMINA LA CONFIGURACION DE LA VENTANA

            //AQUI INICIA EL CUADRO DE AVISO
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            cuadro(8, 68, 7, 18);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(39, 19);
            Console.WriteLine("AVISOS");
            StreamReader arhivo = new StreamReader(@"C:\Windows\Temp\BD\aviso.txt");
            int con = 0;
            while (true)
            {
                string line1 = arhivo.ReadLine();
                Console.SetCursorPosition(9, 21 + con);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(line1);
                if (line1 == null)
                {
                    break;
                }
                con++;
            }
            arhivo.Close();
            //AQUI TERMINA EL CUADRO DE AVISO

            //AQUI INICIA LAS OPCIONES DE LOS 3 CUADROS
            bool ejecutar = false;
            for (int k = 0; ;)
            {
                opciones(k);
                Console.CursorVisible = false;

                ConsoleKeyInfo cki = Console.ReadKey(true);
                switch (cki.Key)
                {
                    case ConsoleKey.RightArrow: k++; break;
                    case ConsoleKey.LeftArrow: k--; break;
                    case ConsoleKey.Escape: ejecutar = true; break;
                }
                if (k < 0) k = 2; else if (k > 2) k = 0;

                //SE CIERRA EL PRICICPAL 
                if (ejecutar) {
                    break;
                }
            }
            //AQUI TERMINA LAS OPCIONES DE LOS 3 CUADROS
        }
    }
}
