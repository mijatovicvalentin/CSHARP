using System;



namespace EO1Metode
{
    public class Metode
    {
        //ova metoda se moze pozvati na istanci klase

        public void ispis()
        {
            Console.WriteLine("Hello");
        }

        public void ispis(string poruka)
        {
            Console.WriteLine(poruka);
        }

        public void ispis(int poruka)
        {
            Console.WriteLine(poruka);
        }

        //ova metoda se moze pozvati s same klase
        //<summary>
        /// <summary>
        /// Metoda zbraja 2 primljena broja
        /// </summary>
        /// <param name="a">prvi primljeni broj</param>
        /// <param name="b">drugi  primljeni broj</param>
        /// <returns> zbroj dvaju primljenih brojeva</returns>

        public static int izracunaj(int a, int b)
        {
            return a + b;
        }






        public static void ispisiMatricu(int[,] matrica)
        {
            for (int i = 0; i < matrica.GetLength(0); i++)
            {
                for (int j = 0; j < matrica.GetLength(1); j++)

                {
                    Console.Write(matrica[i, j] + " ");
                }
                Console.WriteLine();
            }
            string s = "";
            for (int i = 0; i < (matrica.GetLength(1) * 2) - 1; i++)
            {
                s += "*";
            }


            Console.WriteLine(s);
        }
        //rekurzija je kada metoda poziva samu sebe uz 
        //uvjet prekida rekurzuije

        public static int faktorijel(int broj) //kod pisanja rekurzije uvijek prvo pises uvjet
        {
            if(broj==1)
            {
                return broj;
            }
            return broj * faktorijel(broj - 1);
        }
    }

}

