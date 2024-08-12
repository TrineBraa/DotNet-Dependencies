
namespace Objects_2
{
    internal class Pokedex
    {
        public string Name;
        public int Health;
        public int Level;

        public Pokedex(string name, int health, int level)
        {
            Name = name;
            Health = health;
            Level = level;

        }

        public Pokedex()
        {
            
        }

        public void ShowPokedex()
        {
                Console.WriteLine("Some Pokemon created by use of a Constructor.");
                Console.WriteLine();
                Console.WriteLine(Name);
                Console.WriteLine($"Health: {Health}");
                Console.WriteLine($"Level: {Level}");
        }
        public void PokedexObjects()
        {
            bool Circle = true;
            while (Circle)
            {

                Console.WriteLine("to return to exit app press 0");


                ShowPokedex();


                string Input = Console.ReadLine();
                int Input2 = Convert.ToInt32(Input);
                if (Input2 == 0)
                {
                    Circle = false;
                }

            }
        }
    }
   
}
