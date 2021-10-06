using System;

namespace HOCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!"

            int counterH = 0;
            int counterO = 0;
            int counterL = 0;

            for (int i = 0; i < helloW.Lenght; i++)
            {
                if (helloW[i] == 'h')
                {
                    counterH++;
                }
                else if(helloW[i]== 'o')
                {
                    counterO++;
                }
                else
                {
                    continue;
                }
                Console.WriteLine($"Lauses {helloW} on {counterH} 'h' tähte, {counterO} 'o' tähte ja {counterL} 'l' tähte");
            }



        }
    }
}
