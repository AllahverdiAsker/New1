using System;

namespace WorkToDo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human(12)
            {
                Name = "Hasan"
            };
            Human human2 = new Human(42)
            {
                Name = "Kerem"
            };
            Human human3 = new Human(42)
            {
                Name = "Ihsan"
            };
            Human human4 = new Human(42)
            {
                Name = "Xalid"
            };
            Human[] lists = { human1,human2,human3,human4 };
            Console.WriteLine("Select Number");
            string selection = Console.ReadLine();
            Selection(ref selection,ref lists);

            static void Selection(ref string selection,ref Human[] lists)
            {
                foreach(var item in lists)
                {
                    if (item.Name.Contains(selection))
                    {
                        Console.WriteLine(item.Name);
                    }

                }

            }

        }
    }
}
