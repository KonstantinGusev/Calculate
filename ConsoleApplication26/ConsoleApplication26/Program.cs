using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication134
{
    using System.Threading;

    class Program

    { 
        static void Main(string[] args)
        {
            
            var shapes = new List<Shape>();

           

                shapes.Add(new Star(5, 5, ConsoleColor.White));
                
                shapes.Add(new AnyStar(5, 5, ConsoleColor.Cyan, ConsoleColor.Gray));
          
            while (true)
                {

                Engine.Draw(shapes);
              
            }
            
        }
    }

    static class Engine
    {
        public static void Clean()
        {
            Console.Clear();
        }

        public static void SetPixel(int x, int y, ConsoleColor color = ConsoleColor.DarkBlue)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(@" 
            ████████████████████████████████████╔═════════════════════╗
            ███████░░░██████████████████████████║░░░░░░░░░░░░░░░░░░░░░║
            ███████░░░░███████████████████▀░░▀██║░░░░░░░░░░░░░░░░░░░░░║
            ███████▄░░░███████████████████░░░░██║░░███████░░░███████░░║
            ████████░░░░█████████████████░░░░▄██║░███░░░██░░███░░░███░║
            ████████▄░░░▀███████████████▀░░░░███║░░███████░░░███████░░║
            █████████░░░░███▀░░░██▀▀████░░░░▄███║░░░░░░░░░░░░░░░░░░░░░║
            █████████▄░░░▀██░░░░█░░░░██▀░░░░████║░░░░░░░░░░░░░░░░░░░░░║
            ██████████░░░░██░░░░█░░░░██░░░░░████║█░░░░░░░░░░░░░░░░░░░█║
            █░░░░██████░░░░█░░░░█░░░░█░░░░░█████║█░░░░░█████████░░░░░█║
            ██░░░░░██░░░░░░░░░░░░░░░░█░░░░██████║██░░█████░░░█████░░██║
            ███░░░░░░░░░░░░░░░░░░░░░░█░░░ ██████║█████░░░░░░░░░░░█████║
            ██████░░░░░░░░▄▄▄▄░░░░░░█░░░░░██████║██████░░░░█░░░░██████║
            ████████░░░░░░░░░░▀▀█▀▀░░░░░░░██████║░███████████████████░║
            █████████░░░░░░░░░░░█▄░░░░░░░███████║░███████████████████░║
            █████████▄░░░░░░░░░░░█░░░░░░████████║░░█████████████████░░║
            ██████████░░░░░░░░░░░▀░░░░░░████████║░░░███████████████░░░║
            ███████████░░░░░░░░░░░░░░░░█████████║░░░░█████████████░░░░║
            ███████████▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄██████████║░░░░░███████████░░░░░║
            ████████████████████████████████████║░░░░░░░░█████░░░░░░░░║
        ");
        }
        public static void SetPixel2(int x, int y, ConsoleColor color = ConsoleColor.DarkBlue)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(@"                    
            ████████████████████████████████████╔═════════════════════╗
            ███████░░░██████████████████████████║░░░░░░░░░░░░░░░░░░░░░║
            ███████░░░░███████████████████▀░░▀██║░░░░░░░░░░░░░░░░░░░░░║
            ███████▄░░░███████████████████░░░░██║██████████░██████████║
            ████████░░░░█████████████████░░░░▄██║░███████████████████░║
            ████████▄░░░▀███████████████▀░░░░███║░░███████░░░███████░░║
            █████████░░░░███▀░░░██▀▀████░░░░▄███║░░░█████░░░░░█████░░░║
            █████████▄░░░▀██░░░░█░░░░██▀░░░░████║░░░░░░░░░░░░░░░░░░░░░║
            ██████████░░░░██░░░░█░░░░██░░░░░████║█░░░░░░░░░░░░░░░░░░░█║
            ███████████░░░░█░░░░█░░░░██░░░░█████║█░░░░░█████████░░░░░█║
            ████████████▀▀▀▀▀▀▀▀█░░░░█░░░░░█████║██░░█████░░░█████░░██║
            ███████████░░░░░░░░░░█░░░█░░░░▄█████║█████░░░░░░░░░░░█████║
            █████████▀░░░░▄▄▄▄░▄█░░░█░░░░░██████║██████░░░░█░░░░██████║
            ████████▀░░░░░░░░▀▀█▀▀▀▀░░░░░░██████║░███████████████████░║
            █████████░░░░░░░░░░░█▄░░░░░░░░██████║░███████████████████░║
            █████████▄░░░░░░░░░░░█░░░░░░░███████║░░█████████████████░░║
            ██████████░░░░░░░░░░░▀░░░░░░▄███████║░░░███████████████░░░║
            ███████████░░░░░░░░░░░░░░░░░████████║░░░░█████████████░░░░║
            ███████████▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█████████║░░░░░███████████░░░░░║
            ████████████████████████████████████║░░░░░░░░█████░░░░░░░░║

        ");
        }

        public static void Draw(List<Shape> shapes)
        {
            Engine.Clean();
            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            Thread.Sleep(100);
        }
    }

    abstract class Shape
    {
        public abstract void Draw();

        public int X { get; set; }

        public int Y { get; set; }

        protected Shape(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    class Star : Shape
    {
        public Star(int x, int y, ConsoleColor color)
            : base(x, y)
        {
            this.Color = color;
        }

        public ConsoleColor Color { get; set; }

        public override void Draw()
        {


                Engine.SetPixel(X , Y, this.Color);
                Engine.SetPixel(X, Y , this.Color);
                Engine.SetPixel(X,  Y, this.Color);

            Thread.Sleep(500);
                Engine.Clean();
            
            
        }
    }

    class AnyStar : Star
    {
        public AnyStar(int x, int y, ConsoleColor color1, ConsoleColor color2)
            : base(x, y, color1)
        {
            this.color1 = color1;
            this.color2 = color2;
        }

        public override void Draw()
        {
            this.Color = (this.i++) % 2 == 0 ? this.color1 : this.color2;
            base.Draw();
            for(int i=0;i<16;i++)
            Engine.SetPixel2(X , Y , this.Color);
            Engine.SetPixel2(X , Y , this.Color);
            Engine.SetPixel2(i + X, Y, this.Color);

            Thread.Sleep(500);
            Engine.Clean();
        }

        private int i = 0;

        private ConsoleColor color1;

        private ConsoleColor color2;
    }
}
