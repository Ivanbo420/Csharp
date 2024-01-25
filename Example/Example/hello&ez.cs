using System;
using System.Security.Principal;

namespace ExampleProj
{
    //base class
    public class Ex1 { }
    //derived class
    public class Ex2 : Ex1 { }

    //class declaration, udt, attributes, methods.
    class Box
    {
        private int lenght;
        private int width;
        private int height;

        public Box(int l, int w, int h)
        {
            this.lenght = l;
            this.width = w;
            this.height = h;
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return height;
        }

        public int GetLenght()
        {
            return lenght;
        }

        //operator overloading, defines the behavior of the + operator for the Box class
        public static Box operator +(Box b, Box c)
        {
            return new Box(b.GetLenght() + c.GetLenght(), b.GetWidth() + c.GetWidth(), b.GetHeight() + c.GetHeight());
        }
    }
      class Program{ 
        static void Main()
        {
            //console ouput print statement
            Console.WriteLine("Hello World!");

            //variable declaration per type
            int x = 5;
            float y = 6.5f;
            string z = "bird";
            char a = 'a';
            bool complete = true;

            //conditional statements
            if (complete)
            {
                x = 3;
            }
            else if (x == 5)
            {
                x = 2;
            }
            else
            {
                x = 3;
            }

            /*for loops iterates over a collection*/
            List<string> collection = new List<string>() { "a", "b", "c" };
            for (int i = 0;i < collection.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine(collection[i]);
            }

            // while loops iterate until a condition is met
            while (x > 0)
            {
                System.Diagnostics.Debug.WriteLine("Loading");
                x--;
            }

            //function call
            PrintHi("Hello motherfucker");

            /* inheritance example
             * is operator assigns either true or false to the boolean var in case the specified type matches or not++*/
            Ex2 ex2Object = new Ex2();
            bool b = ex2Object is Ex1;
            System.Diagnostics.Debug.WriteLine(b);

            //object built
            Box box1 = new Box(2, 2, 2);
            Box box2 = new Box(2, 2, 2);
            Box box3 = box1 + box2;

            System.Diagnostics.Debug.WriteLine("Lenght: " + box3.GetLenght());
            System.Diagnostics.Debug.WriteLine("Width: " + box3.GetWidth());
            System.Diagnostics.Debug.WriteLine("Height: " + box3.GetHeight());

            }

        //function declaration
        static void PrintHi(string message)
        {
            System.Diagnostics.Debug.WriteLine("Hi");
            System.Diagnostics.Debug.WriteLine(message);

        }
    }
}