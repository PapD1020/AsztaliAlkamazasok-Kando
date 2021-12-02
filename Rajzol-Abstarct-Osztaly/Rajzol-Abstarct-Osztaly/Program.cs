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
        public abstract int Perimeter();

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

        public override int Perimeter()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(3, 4);
            c.Draw();
            Console.ReadLine();

            c.Move(5, 6);
            Console.ReadLine();

            c.Move(3, 4);
            Console.ReadLine();
        }
    }
}
