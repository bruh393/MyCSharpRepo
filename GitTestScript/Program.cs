//class gitTest
//{
//    public static void Main()
//    {
//        Console.WriteLine("meth");
//    }
//}

class Calc
{
    public static void Main()
    {
        Console.Write("first digit :");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("second digit :");
        double n2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("select operetor :");
        string o = Console.ReadLine();
        double ans = 0; 

        if (o == "+")
        {
            ans = n1 + n2;
        }
        else if (o == "-")
        {
            ans = n1 - n2;
        }
        else if (o == "/")
        {
            ans = n1 / n2;
        }
        else if(o == "*")
        {
            ans = n1 * n2;
        }
        else if(o == "%")
        {
            ans = n1 % n2;
        }
        else
        {
            Console.WriteLine("math error");
        }
        

        
        Console.WriteLine(ans);
    }
}