using System;


namespace PartTwo
{
    public class SequenceNum
    {
        public void PrintSequence(int numbers)
        {

            int a = 0;
            int b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i < numbers; i++)
            {
                int c = a + b;
                a = b;
                b = c;

                Console.WriteLine(c);




            }

        }
    }

}