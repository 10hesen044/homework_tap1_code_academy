using System;

namespace homework_tap1
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrsize, sum = 0, count = 0, qaliq;

            Console.WriteLine("arrayin size daxil edin : ");
            arrsize = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[arrsize];

            Console.WriteLine("arrayin elementlerini daxil edin : ");
            for (int i = 0; i < arrsize; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arrsize; i++)
            {
                while (arr[i] >= 1)
                {
                    qaliq = arr[i] % 10;
                    sum += qaliq;
                    arr[i] /= 10;

                }

                if (sum < 10)
                {
                    count++;
                }
                sum = 0;
            }

            Console.WriteLine("netice : " + count);
        }
    }
}
