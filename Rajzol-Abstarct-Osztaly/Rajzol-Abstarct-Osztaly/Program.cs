using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rajzol_Abstarct_Osztaly
{
    abstract class Grafobject
    {
        protected int x;
        protected int y;

        public abstract void Draw();
        public abstract void Delete();

        public void Move(int moveX, int moveY)
        {
            Delete();
            x += moveX;
            y += moveY;
            Draw();
        }
    }

    class Circle : Grafobject
    {
        public Circle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("O");
        }

        public override void Delete()
        {
            Console.SetCursorPosition(x - 1, y);
            Console.Clear();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(5, 5);

            Circle c = new Circle(3, 4);
            c.Draw();
            s.Draw();
            Console.ReadLine();

            c.Move(5, 6);
            s.Move(10, 10);
            Console.ReadLine();

            c.Move(3, 4);
            s.Move(15, 15);
            Console.ReadLine();
        }
    }
}
