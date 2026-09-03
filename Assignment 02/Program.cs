using System;

class program
{
    static void Main(String[] args)
    {


     ///////////Question 1/////////////

        Console.WriteLine("Enter a number:");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("the number is :" + number1);

     //////////Question 2////////////// 

        String str = "nour123";
        int number2 = Convert.ToInt32(str);
        Console.WriteLine(number2);

        // it will throw an unhandled exception of type FormatException because the string "nour123" cannot be converted to an integer.
        //Unhandled exception. System.FormatException: The input string 'nour123' was not in a correct format.

     //////////Question 3//////////////

        float number3 = 10.5f;
        float number4 = 15.5f;
        float result = number3 + number4;
        Console.WriteLine("the result is :" + result);


     /////////Question 4//////////////

        String str2 = "nour hany";
        String str3 = str2.Substring(0, 3);
        Console.WriteLine("the substring is :" + str3);


        ////////Question 5//////////////

        int x=10;
        int y = x;

        y= 20;

        Console.WriteLine("the value of x is :" + x);
        Console.WriteLine("the value of y is :" + y);

        //When one value type variable is assigned to another a copy of the value is made Therefore modifying one variable does not affect the other variable.
        // value type [int , double , float , char , bool ,struct , enum] are stored in Stack.

     ////////Question 6//////////////

        int[] arr1= new int[3] { 1, 2, 3 };
        int[] arr2 = arr1;

        arr1[0] = 10;

        for (int i = 0; i < 3; i++)
        {
            Console.Write(arr1[i] + " ");
        }

        Console.WriteLine();

        for (int i = 0; i < 3; i++)
        {
            Console.Write(arr2[i] + " ");
        }
        // Both arrays have changed as they are refernce types and point to the same object (array).
        // reference type [class , interface , delegate , array] are stored in Heap.

        ////////Question 7//////////////

        String str4 = Console.ReadLine();
        String str5 = Console.ReadLine();

        Console.WriteLine(str4 +" "+ str5);

     /////////Question 8//////////////

        /*  Which of the following statements is correct about the C#.NET code snippet given below?

                     int d;
                     d = Convert.ToInt32(!(30 < 20));

              1.A value 0 will be assigned to `d`.
              2.A value 1 will be assigned to `d`.
              3.A value - 1 will be assigned to `d`.
              4.The code reports an error.
              5.The code snippet will work correctly if `!` is replaced by `Not`.
        */

        // The correct answer is 2. A value 1 will be assigned to `d`. <------------------------------


     /////////Question 9//////////////

        /* Which of the following is the correct output for the C# code given below?


                       Console.WriteLine(13 / 2 + " " + 13 % 2);


                       1)6.5 1
                       2)6.5 0
                       3)6 0
                       4)6 1
                       5)6.5 6.5
              The Answer is 4)6 1 <-----------------------------
        */


     ////////Question 10//////////////

        /*   What will be the output of the C# code given below?


                int num = 1, z = 5;


                        if (!(num <= 0))
                            Console.WriteLine(++num + z++ + " " + ++z);
                        else
                            Console.WriteLine(--num + z-- + " " + --z);




                      1)  5 6
                      2)  6 5
                      3)  6 6
                      4)  7 7

                The Answer is 3) 6 6 <-----------------------------


        */

    }


}


