using System;

namespace lab2ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 3 Să se scrie un program care citeşte de la tastatură un şir de n numere
                    naturale şi determină media aritmetică a celor pare, n fiind citit de la
                    tastatra
             */

            Console.WriteLine("Introduceti un sir de numere:");

            int nums = int.Parse(Console.ReadLine());
            int sum;
            int countNrPare;
            
            for (int i = 1; nums > 0; i++)
            {
                //daca ultima cifra este para
                if ((nums % 10) % 2 == 0)
                {
                    //adaugam ultima cifra la suma
                    sum = sum + nums % 10;
                    //adaugam +1 la count-ul numerelor pare 
                    countNrPare++;
                }
                //scoatem ultima cifra din numar
                nums = nums / 10;
            }

            if (countNrPare > 0)
            {
                Console.WriteLine("Media artitmetica a numerelor pare din sir este: " + sum / countNrPare);
            } else
            {
                Console.WriteLine("Nu exista nici un numar par in sir");
            }

        }
    }
}
