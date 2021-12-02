using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rajzol_Abstarct_Osztaly
{
    abstract class CharacterSquare
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

    class Square : Grafobject
    {
        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("KOCKA");
        }

        public override void Delete()
        {
            Console.SetCursorPosition(x - 1, y);
            Console.Clear();
        }
    }
}
