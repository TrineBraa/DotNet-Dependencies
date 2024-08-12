
using Objects_2;

Pokedex pokedex = new Pokedex("Eevee", 43, 23);
Person person = new Person();
Overload overload = new Overload();
Main();

void Main()
{
    Console.WriteLine("\nTime to look more at Objectives, Constructors and objectives in lists. \n\t This will be a collection of different Moodle tasks.");
    Console.WriteLine();
    Console.WriteLine("\nThis program will contain multiple different tasks that might also move past from the Objective tasks.");
    Console.WriteLine();
    MainMenu();
    Console.WriteLine();
    MainSwitch();


}


void MainMenu()
{
    Console.WriteLine("Different moodle tasks: ");
    Console.WriteLine();
    Console.WriteLine("\t 0. to exit the app");
    Console.WriteLine("\t 1. the objective and constructor.");
    Console.WriteLine("\t 2. A list of people by constructor and objectives.");
    Console.WriteLine("\t 3. A little welcome msg with overloads.");
}

void MainSwitch()
{
    string UserInput = Console.ReadLine();
    int Number = Convert.ToInt32(UserInput);
    switch (Number)
    {
        case 1:
            pokedex.PokedexObjects();
            break;
        case 2:
            person.AddPeople();
            break;
        case 3:
            overload.ShowWelcome();
            break;
        case 0:
            break;
    }
}










