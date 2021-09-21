using System;

namespace ConsoleApplication2
{
    class Point
    {
        public float x, y;
        public Point(float _x, float _y)
        {
            x = _x;
            y = _y;
        }
        
        public void Cords()
        {
            Console.WriteLine("Cords: "+ x + y);
        }
    }

    class segment : Point
    {
        public Point a;
        public Point b;
        public float Length;
        public segment(float _ax, float _ay, float _size) : base(_ax, _ay)
        {
            a = new Point(_ax, _ay);
            b = new Point(_ax, _ay + _size);
            Length = _size;
        }
        public void Leni() { Console.WriteLine(" " + a.x + + a.y + Environment.NewLine + b.x + b.y + Length + Environment.NewLine); }
    }

    class Triagle : segment
    {
        public segment A;
        public segment B;
        public segment C;
        public Point at;
        public Point bt;
        public Point ct;
        public float area;
        public float h;
        public float size;
        public Triagle(segment _a, float _ax, float _ay, float _size) : base(_ax, _ay, _size)
        {

            size = _size;
            h = (float)((size * Math.Sqrt(3)) / 2);

            at = new Point(_ax, _ay);
            bt = new Point(_ax, _ay+_size);
            ct = new Point(h + at.x, (float)((size / 2) + at.y));

            A = _a;
            B = new segment(_ax, _ay+size+at.x, size);
            C = new segment(ct.x, ct.y, size);

            area = (float)(h * size) / 2;
        }

        public void Area()
        {
            Console.WriteLine("Площадь: " + area);
        }

        public void property()
        {
            Console.WriteLine("Площадь: " + area + Environment.NewLine +
                "Длина сторон: " + size + Environment.NewLine);
            Console.WriteLine("Координаты: a(" + at.x + ',' + at.y + ")");
            Console.WriteLine("            b(" + bt.x + ',' + bt.y + ")");
            Console.WriteLine("            c(" + ct.x + ',' + ct.y + ")");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cords for a: ");
            Point a = new Point(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
            Console.WriteLine("==============================================================================");
            Console.WriteLine("Size for A: ");
            segment A = new segment(a.x, a.y, float.Parse(Console.ReadLine()));
            Triagle ABC = new Triagle(A, a.x, a.y, A.Length);
            Console.WriteLine("==============================================================================");
            ABC.Area();
            Console.WriteLine("==============================================================================");
            ABC.property();
            Console.WriteLine("==============================================================================");
            Console.ReadLine();
        }
    }
}
