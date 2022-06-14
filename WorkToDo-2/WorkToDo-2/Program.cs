using System;

namespace WorkToDo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Say daxil et");

            int number = Convert.ToInt32(Console.ReadLine());

            Milk[] milks = new Milk[number];

            Return(ref milks);

            

            static Milk[] Return(ref Milk[] milks)
            {
                for (int i = 0; i < milks.Length; i++)
                {
                    Milk milk = new Milk();
                    Console.WriteLine("Name daxil et");
                    milk.Name = Console.ReadLine();

                    Console.WriteLine("Price daxil et");
                    milk.Price = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Discount daxil et");
                    milk.FatPercentage = Convert.ToInt32(Console.ReadLine());

                    milks[i] = milk;
                }
                return milks;
                
            }

            



        }
            

        }
    }


