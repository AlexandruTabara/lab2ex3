using System;

namespace lab2ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex 3 Să se scrie un program care citeşte de la tastatură un şir de n numere
                naturale şi determină media aritmetică a celor pare, n fiind citit de la tastatra */

            int sirNumere;
            int sumaNrPare = 0;
            int adunareNrPare = 0;

            Console.WriteLine("Introduceti marimea sirului:");
            sirNumere = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[sirNumere];

            Console.WriteLine("Intoduceti valorile:");
            for (int i = 0; i < sirNumere; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < sirNumere; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sumaNrPare += arr[i];
                    adunareNrPare++;
                }

            }

            Console.WriteLine("Media aritmetica a numerelor pare este este: " + sumaNrPare / adunareNrPare);
        }
    }
}
