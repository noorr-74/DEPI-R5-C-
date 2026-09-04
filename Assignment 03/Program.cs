using System;

class Program
{
    static void Main()
    {

        //Question 1
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 3 == 0 && number % 4 == 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }


        //Question 2
        Console.Write("Enter an integer: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        if (number1 < 0)
        {
            Console.WriteLine("negative");
        }
        else if (number1 > 0)
        {
            Console.WriteLine("positive");
        }
        else
        {
            Console.WriteLine("zero");
        }


        //Question 3
        Console.Write("Enter first number: ");
        int number0 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        int max = number0;
        int min = number0;

        if (number2 > max)
        {
            max = number2;
        }


        //Question 4
        Console.Write("Enter an integer: ");
        int x = Convert.ToInt32(Console.ReadLine());

        if (x % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }


        //Question 5
        Console.Write("Enter a character: ");
        char character = Convert.ToChar(Console.ReadLine());

        if (character == 'a' || character == 'e' || character == 'i' ||
            character == 'o' || character == 'u' ||
            character == 'A' || character == 'E' || character == 'I' ||
            character == 'O' || character == 'U')
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("consonant");
        }


        //Question 6
        Console.Write("Enter an integer: ");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            Console.Write(i + " ");
        }

        //Question 7   
        Console.Write("Enter an integer: ");
        int number5 = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 12; i++)
        {
            Console.Write(number5 * i + " ");
        }
    }
}