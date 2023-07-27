//TABLICA MNOZENJA


Console.Write("Upišite vaše  ime: ");
string ime = Console.ReadLine();
string a;
string b;

for (int i = 0; i < 9; i++)
{
    if (i == 0 | i == 2 | i == 4 | i == 6 | i == 8)
    {
        Console.WriteLine("-------------------------------");
    }
    else if (i == 1)
    {
        Console.WriteLine(": : :  TABLICA  MNOZENJA  : : :");
    }
    else if (i == 3)
    {
        Console.Write(" * |");
        for (int d = 1; d < 10; d++)
        {
            Console.Write("  " + d);
        }
        Console.WriteLine();
    }

    else if (i == 5)
    {

        for (int g = 1; g < 10; g++)
        {
            Console.Write(" " + g + " |");
            for (int q = 1; q < 10; q++)
            {
                a = "   " + g * q;
                Console.Write(a[^3..]);
            }
            Console.WriteLine();
        }
    }

    else if (i == 7)
    {
        b = ":  :  :  :  :  :  :  :  :  :  :  :  " + "by " + ime;
        Console.WriteLine(b[^31..]);

    }

}//TABLICA MNOZENJA


Console.Write("Upišite vaše  ime: ");
string ime = Console.ReadLine();
string a;
string b;

for (int i = 0; i < 9; i++)
{
    if (i == 0 | i == 2 | i == 4 | i == 6 | i == 8)
    {
        Console.WriteLine("-------------------------------");
    }
    else if (i == 1)
    {
        Console.WriteLine(": : :  TABLICA  MNOZENJA  : : :");
    }
    else if (i == 3)
    {
        Console.Write(" * |");
        for (int d = 1; d < 10; d++)
        {
            Console.Write("  " + d);
        }
        Console.WriteLine();
    }

    else if (i == 5)
    {

        for (int g = 1; g < 10; g++)
        {
            Console.Write(" " + g + " |");
            for (int q = 1; q < 10; q++)
            {
                a = "   " + g * q;
                Console.Write(a[^3..]);
            }
            Console.WriteLine();
        }
    }

    else if (i == 7)
    {
        b = ":  :  :  :  :  :  :  :  :  :  :  :  " + "by " + ime;
        Console.WriteLine(b[^31..]);

    }

}