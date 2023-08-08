//TABLICA MNOŽENJA


Console.Write("Molimo upišite vaše ime: ");
string ime = Console.ReadLine();
string j;
string v;

for (int a = 0; a < 9; a++)
{
    if (a == 0 | a == 2 | a == 4 | a == 6 | a == 8)
    {
        Console.WriteLine("-------------------------------");
    }
    else if (a == 1)
    {
        Console.WriteLine(": : :  TABLICA  MNOZENJA  : : :");
    }
    else if (a == 3)
    {
        Console.Write(" * |");
        for (int d = 1; d < 10; d++)
        {
            Console.Write("  " + d);
        }
        Console.WriteLine();
    }

    else if (a == 5)
    {

        for (int l = 1; l < 10; l++)
        {
            Console.Write(" " + l + " |");
            for (int m = 1; m < 10; m++)
            {
                j = "   " + l * m;
                Console.Write(j[^3..]);
            }
            Console.WriteLine();
        }
    }

    else if (a == 7)
    {
        v = ":  :  :  :  :  :  :  :  :  :  :  :  " + "by " + ime;
        Console.WriteLine(v[^31..]);

    }

}