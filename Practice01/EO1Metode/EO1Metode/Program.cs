int dajbroj()
{
    while (true)
    {
        Console.Write("Daj mi broj:  ");
        try



        {
            return int.Parse(Console.ReadLine());
        }
        catch(FormatException)
        {
            Console.WriteLine("Probaj ponovno");
        }
        catch(OverflowException) 
        {
            Console.WriteLine("Broj je prevelik");
        }
        catch(Exception) 
        {
            Console.WriteLine("Ooop pokušaj ponovno");
        }
        finally
        {

        }
    }
}
int k = dajbroj();
int j = dajbroj();
for (int o = 1; o <= 10; o++)
    Console.WriteLine(k + j + o);