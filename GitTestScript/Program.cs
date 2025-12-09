using System;
//class gitTest
//{
//    public static void Main()
//    {
//        Console.WriteLine("meth");
//    }
//}

//class Calc
//{
//    public static void Main()
//    {
//        Console.Write("first digit :");
//        double n1 = Convert.ToDouble(Console.ReadLine());
//        Console.Write("second digit :");
//        double n2 = Convert.ToDouble(Console.ReadLine());
//        Console.Write("select operetor :");
//        string o = Console.ReadLine();
//        double ans = 0; 

//        if (o == "+")
//        {
//            ans = n1 + n2;
//        }
//        else if (o == "-")
//        {
//            ans = n1 - n2;
//        }
//        else if (o == "/")
//        {
//            ans = n1 / n2;
//        }
//        else if(o == "*")
//        {
//            ans = n1 * n2;
//        }
//        else if(o == "%")
//        {
//            ans = n1 % n2;
//        }
//        else
//        {
//            Console.WriteLine("Math Error");
//        }
        

        
//        Console.WriteLine(ans);
//    }
//}

class Odd
{
    public static void Main()
    {
        Console.Write("enter your number");
        double n = Convert.ToDouble(Console.ReadLine());

        if(n % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
}