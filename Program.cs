using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutaja sisestada numbrit -10 kuni 10
            //programm kontrollib numbrit
            //kui number on positiivne, konsool kuvab "positiivne"
            //kui number on negatiivne, konsool kuvab "null"
            Console.WriteLine("Sisesta üks number -10 kuni 10");
            int Number = Convert.ToInt32(Console.ReadLine());
           
                if (Number < 0)
            {
                    Console.WriteLine("Number on negatiivne");
            }
            
            else if (Number > 0)
            {
                Console.WriteLine("Number on positiivne");
            }
            
             else
            { 
                Console.WriteLine("Number on null");
            }
        }
    }
}
