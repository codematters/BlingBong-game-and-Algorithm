using System;

namespace PartOne
{
    public class BlingGame
    {
        public void PrintNum()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("BlingBlong");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Blong");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Bling");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}