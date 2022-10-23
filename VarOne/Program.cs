using System;


namespace VarOne
{
    class NumberTwo
    {
        static public void Main()
        {
            Console.WriteLine(string.Empty);

            int x;
            double rad;
            double f;

            for (x = 0; x <= 180; x += 10)
            {
                rad = x * Math.PI / 180; // радианы
                f = Math.Cos(x); // значение функции

                Console.WriteLine("| {0,3} | {1,3:F2} | {2,5:F2} |\n|-----|------|-------|", x, rad, f);
            }

            Console.ReadKey();
        }
    }
}
