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
                int c = a + b;// 1// 2 // 3// 5// 8 //13// 21// 34
                a = b;//1// 1// 2 // 3// 5 // 8// 13// 21
                b = c;//1 // 2// 3// 5 // 8// 13// 21 // 34

                Console.WriteLine(c);




            }

        }
    }

}