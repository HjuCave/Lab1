using System;


namespace VarThree
{
    class Class1
    {
        static public void Main()
        {
            Console.WriteLine(string.Empty);

            for (int x = 0; x <= 180; x += 10)
            {
                double rad = x * Math.PI / 180; // радианы
                double f = Math.Sinh(x) / Math.Cosh(x); // значение функции

                Console.WriteLine("| {0,3} | {1,3:F2} | {2,5:F2} |\n|-----|------|-------|", x, rad, f);
            }

            Console.ReadKey();
        }
    }
}
