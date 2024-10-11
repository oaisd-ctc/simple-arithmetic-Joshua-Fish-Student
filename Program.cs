using System;

public class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("What opperator (+, -, *, /, or modulus)?");
        string opp = Console.ReadLine();
        Console.WriteLine("First number?");
        float num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Second number?");
        float num2 = float.Parse(Console.ReadLine());
        if (opp == "+"){
            Console.WriteLine(num1 + " + " + num2 + " is " + (num1 + num2));
        }
        else if (opp == "-"){
            Console.WriteLine(num1 + " - " + num2 + " is " + (num1 - num2));
        }
        else if (opp == "/"){
            Console.WriteLine("Decimal or integer?");
            string option = Console.ReadLine();
            if (option == "integer"){
                num1 = (int)num1;
                num2 = (int)num2;
            }
            Console.WriteLine(num1 + " / " + num2 + " is " + num1 / num2);
        }
        else if (opp == "*"){
            Console.WriteLine(num1 + " * " + num2 + " is " + (num1 * num2));
        }
        else if (opp == "modulus"){
            Console.WriteLine(num1 + " modulus " + num2 + " is " + (num1 % num2));
        }
    }
}