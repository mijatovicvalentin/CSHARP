//1 tip voida ne prima parametre
//deklaracija metode
using ZajednickeMetode;

void Tip1()
{
    Console.WriteLine("Dobrodošli u program");
}
//poziv metode
Tip1();

//tip 2 prima parametre
void tip2(string poruka)
{
    Console.WriteLine(poruka);
}
tip2("Ovo je vrijednost koju prosljeđujem");
string s = "vrijednost varijable s ";
tip2(s);

//3 tip, određenog tipa, ne prima vrijednost
int tip3()
{
    return new Random().Next();
}
tip3(); //on ce vratiti slučajni broj ali kod s tim
//brojem ništa ne radi
Console.WriteLine(tip3());
Console.WriteLine();
    int sb = tip3(); ;
Console.WriteLine(sb);

//NAJBNITNIJA 4 METODA ODREĐENIG TIPA I PRIMA PARAMETRE
int tip4(int min, int max)
{
    int manji = min<max ? min : max;
    int veci = max>min ? max : min;
    sb = 3; //vidimo varijablu izvan metode(razina klasa)
    // poruka = ""; ne vidimo varijablu iz neke druge metode
    return new Random().Next(manji,veci);
}

Console.WriteLine(tip4(20,30));
Console.WriteLine(tip4(-20,-30));
// specifičnost top level statements načina

void ispis()
{
    Console.WriteLine("Hello World");
}
//void ispis(string poruka)
//{
//              [ovo en moze ici u top level statements]]
//}
//

Metode m = new Metode();    //instanca klase metode

m.ispis();
m.ispis("12");
m.ispis(12);
Console.WriteLine(Metode.izracunaj(2,8));


int[,] t = new int[5, 5];
Metode.ispisiMatricu(t);
t[2, 4] = 7;
Metode.ispisiMatricu(t);

Console.WriteLine(Metode.faktorijel(5));


//-----------------------------------------------//
//Ako korisnik umjesto broja unese slovo, dogodi se iznimka i nju možemo obraditi.

int ucitajBroj()
        {
    while (true)
    {
        Console.Write("Unesi broj: ");
        try     // upišemo try i onda tab tab da dobijemo try-catch blok
                // try-catch inače ima 3 dijela: try, catch i finally
                // ali finally nije obavezan
                // throw dio treba obrisati, to nam ne treba

        {
            // ovdje će uvijek ući
            // tu stavljamo kod za kojeg očekujemo da će baciti iznimku

            return int.Parse(Console.ReadLine());

            // ako se dogodi iznimka, on se prebacuje u catch i ispisuje "Ne može"
            // ako korisnik unese broj, on se ispiše i izlazimo iz beskonačne petlje
        }
        catch (FormatException e)
        // Ako korisnik unese slovo umjesto broja, to će nam dati FormatException
        // možemo još dodati varijablu e koja će sadržavati podatke o iznimci
        {
            // ovdje dođe ako se dogodila iznimka
            Console.WriteLine("Ne može!");

        }
        catch (OverflowException)
        // Ako korisnik unese prevelik broj javit će se OwerflowException
        {
            Console.WriteLine("Ne pretjeruj!");
        }
        catch (Exception)           //u slučaju da se dogodila neka druga iznimka
        {
            Console.WriteLine("Ooops, nešto nije dobro...");
        }
        finally


        {
            //ovdje uvijek dođe

            // ovo je jako važno, zbog rada s bazom
            // da se ne bi dogodilo da je upit loše napisan i baci nam SQL Exception
            // bez obzira je li prošlo ili puklo, zatvori vezu na bazu       
        }
    }


}


int i = ucitajBroj();
int j = ucitajBroj();

Console.WriteLine(i + j);

