using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("X\tY\tZ\tExpr1\tExpr2");

        for (int x = 0; x <= 1; x++)
        {
            for (int y = 0; y <= 1; y++)
            {
                for (int z = 0; z <= 1; z++)
                {
                    bool X = x == 1;
                    bool Y = y == 1;
                    bool Z = z == 1;

                    bool expr1 = (!X && Z) || (Y && !Z);
                    bool expr2 = !Y || (X && !Z && Z);

                    Console.WriteLine($"{X}\t{Y}\t{Z}\t{expr1}\t{expr2}");
                }
            }
        }
    }
}
