using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramacion
{
    class cuadros
    {
        public void cuadro(int height, int width, int x, int y)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.SetCursorPosition(x + j, y + i);
                    Console.WriteLine("█");
                }
            }
        }
        public void marco()
        {
           
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.SetCursorPosition(1, 1);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\t\t\t\t\t\t\t\t      ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" _ ");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" ⌂ ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" X ");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, 2);
            Console.Write("\t\t\t\t\t\t\t\t\t\t");
            Console.SetCursorPosition(2, 3);
            Console.Write("\t\t\t\t\t\t\t\t\t\t");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(32, 2);
            Console.WriteLine("Laboratory System");
            for (int i = 0; i < 78; i++)
            {
                Console.SetCursorPosition(1 + i, 28);
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
            }
            for (int i = 0; i < 28; i++)
            {
                Console.SetCursorPosition(1, 1 + i);
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
            }
            for (int i = 0; i < 28; i++)
            {
                Console.SetCursorPosition(79, 1 + i);
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
            }
          

        }
        public void line(int width,int x,int y)
        {
          
            for (int i = 0; i < width; i++)
            {
                Console.SetCursorPosition(x+i, y);
                Console.WriteLine("_");
            }
        }
    }
}
