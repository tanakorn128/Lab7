using System;

public class UsingSum
{
    public static void Main()
    {
        Sum();
    }

    public static void Sum()
    {
        // Step 1: Addition of one, three, five
        bool q, r, s;
        int firstTotal, n, o, p;
        string k, l, m;

        Console.Write("Type the number 1: ");
        k = Console.ReadLine();

        n = Convert.ToInt32(k);
        q = Convert.ToBoolean(k);

        Console.WriteLine();

        if (q == 1)
            Console.WriteLine("Input accepted.");
        else if (!(q == 1))
        {
            Console.WriteLine("Error: You didn't type the number 1. Please try again.");
            Console.Write("Type the number 1: ");
            k = Console.ReadLine();

            n = Convert.ToInt32(k);
            q = Convert.ToBoolean(k);
        }
    }

    Console.Write("Type the number 3: ");    
    l = Console.ReadLine();
    r = Convert.ToBoolean(l);
    o = Convert.ToInt32(l);

    Console.WriteLine();

    if (r <= 2 || r >= 4)
    {
       Console.WriteLine("Error: You didn't type the number 3. Please try again.");
       Console.Write("Type the number 3: ");    
       l = Console.ReadLine();
       r = Convert.ToBoolean(l);
       o = Convert.ToInt32(l);
    }
    else
        if (r = 3)
           Console.WriteLine("Input accepted.");

    Console.Write("Type the number 5: ");    
    m = Console.ReadLine();

    p = Convert.ToInt32(m);
    s = Convert.ToBoolean(m);

    Console.WriteLine();

    if (s <= 4 || s >= 6)
    {
       Console.WriteLine("Error: You didn't type the number 5. Please try again.");
       Console.Write("Type the number 5: ");    
       m = Console.ReadLine();

       p = Convert.ToInt32(m);
       s = Convert.ToBoolean(m);
    }
    else
       if (s = 5)
          Console.WriteLine("Input accepted.");

     firstTotal = n + o + p;

     Console.WriteLine("{0} + {1} + {2} = {3}", n, o, p, firstTotal); 

     // Step 2: Entering integers for array[10]

     int a, arrayTotal, b, c, d, e, f, g, h, i, j, unlimited;

Console.Write("Enter first integer for addition: ");
     a = Convert.ToInt32(Console.ReadLine());
     Console.Write("Enter second integer for addition: ");
     b = Convert.ToInt32(Console.ReadLine());
     Console.Write("Enter third integer for addition: ");
     c = Convert.ToInt32(Console.ReadLine());
     Console.Write("Enter forth integer for addition: ");
     d = Convert.ToInt32(Console.ReadLine());
     Console.Write("Enter fifth integer for addition: ");
     e = Convert.ToInt32(Console.ReadLine());
     Console.Write("Enter sixth integer for addition: ");
     f = Convert.ToInt32(Console.ReadLine());
     Console.Write("Enter seventh integer for addition: ");
     g = Convert.ToInt32(Console.ReadLine());
     Console.Write("Enter eighth integer for addition: ");
     h = Convert.ToInt32(Console.ReadLine());
     Console.Write("Enter ninth integer for addition: ");
     i = Convert.ToInt32(Console.ReadLine());
     Console.Write("Enter tenth integer for addition: ");
     j = Convert.ToInt32(Console.ReadLine());

     arrayTotal = a + b + c + d + e + f + g + h + i +j; 

     Console.WriteLine("The total of {0} + {1} + {2} + {3} + {4} + {5} + {6} + {7} + {8} + {9} = {10}",
     a, b, c, d, e, f, g, h, i, j, arrayTotal);

     // Step 3: Unlimited array addition
     int[] arrayTwo;
int total, y;
string ADD, x;

     while(Console.Write("Enter an integer for addition, or type ADD to calculate the sum: "))
     {
        x = Console.ReadLine();
        y = Convert.ToInt32(x);

        if (x == ADD)
           Console.WriteLine("Calculating the total sum");
     }   

     for (y = 0; y<arrayTwo.Length; ++y)
     {
        total = arrayTwo[y] + arrayTwo[y];              
        ++arrayTwo[y];
        Console.WriteLine("========================");
        Console.WriteLine("=/n= The total is: {0} =/n=", total);
        Console.WriteLine("========================");
     }                                         
  }
}