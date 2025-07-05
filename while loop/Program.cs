using System;

class WhileLoopExample
{
    static void Main()
    {
        int i = 1;

        Console.WriteLine("Printing numbers from 1 to 5:");

        while (i <= 5)
        {
            Console.WriteLine(i);
            i++;
        }

        Console.WriteLine("Done!");
        Console.ReadKey();
    }
}
