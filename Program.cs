using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taklif5
{
      static void Main(string[] args)
        {
            Class1 shape1 = new test1();
            var answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.WriteLine("size of the side? ");
                    shape1.a = Convert.ToInt32(Console.ReadLine());
                    shape1.b = shape1.c = 0;
                    shape1.a1= shape1.a2 = 0;
                    break;
                case "2":
                    Console.WriteLine("size of the base? ");
                    shape1.a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("size of the side? ");
                    shape1.a1.WriteLine("size of the other side? ");
                    shape1.a2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("size of the height? ");
                    shape1.b = Convert.ToInt32(Console.ReadLine());
                    shape1.c = 0;
                    break;
                case "3":
                    Console.WriteLine("size of the smallest side? ");
                    shape1.a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("size of the biggest side? ");
                    shape1.b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("size of the other side? ");
                    shape1.a1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("size of the last side? ");
                    shape1.a2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("size of the height? ");
                    shape1.c = Convert.ToInt32(Console.ReadLine());
                    break;
                default :
                    Console.WriteLine("please pick 1,2 or3");
                    return;
                    break;
            }
            Console.WriteLine("Area: ");
            Console.WriteLine(shape1.Masahat());
            Console.WriteLine("perimeter: ");
            Console.WriteLine(shape1.Mohit());
        }

    class test1
    {
        public int a;
        public int b;
        public int c;
        public int mohit;
        public int masahat;
        public int a1;
        public int a2;

        public int Masahat()
        { 

 if (b == 0 && c==0)
  {
   masahat = a * a;  
   }
 else if (c == 0)
 
 {

 masahat = (a * b) / 2;
   }
   else 
 {
 masahat = ((a + b) * c) / 2;
 }
                return masahat;
        }
        public int Mohit()
        {
            if (a1==0 && a2==0)
            {
                mohit = a * 4;
            }
            else if (c == 0)
            {
                mohit = a + a1 + a2;
            }
            else
            {
                mohit = a + b + a1 + a2;
            }

            return mohit;
        }
    }
}

}
