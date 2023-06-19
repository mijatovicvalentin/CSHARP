namespace Practice01app
{

    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Practice01app");

            // // // // // //


            long i = Int64.MaxValue;
            Console.WriteLine(i);

            short  k = short.MinValue;
            Console.WriteLine(k);

            ushort t = ushort.MaxValue;
            Console.WriteLine(t);

            // // // // // //


            int a = 5;

            int b = 7;

            int c = 17;

            Console.WriteLine(a / b - c);


            // // // // // //

            float z = 12.34f;

            Console.WriteLine(z);

            // // // // // //

            bool f = 24  >  31;
            Console.WriteLine(f);

            bool r = 24 == 24;
            Console.WriteLine(r);

            bool d  = 3 != 4;
            Console.WriteLine(d);
        }


    }
}