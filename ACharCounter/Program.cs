using System;

namespace ACharCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm küsib kasutajal sisestada perekonnanime
            //programm kuvab, mitu 'a' tähte kasutaja eesnimes ja 
            //perekonnanimes kokku on

            int counter = 0;
            //'a'

            Console.WriteLine("Sisesta oma eesnimi");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi");
            string lastName =Console.ReadLine();
            string fullName = firstName + lastName.ToLower();
            

            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'a')
                {
                    counter++;
                }
            }

            Console.WriteLine($"Sinu nimes on {counter} a-tähte");




        }
    }
}
