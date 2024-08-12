
namespace Objects_2
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person()
        {
            
        }

         public void AddPeople()
        {
            List<Person> People = new List<Person>();

            Person Num1 = new Person("Trine", 31);
            Person Num2 = new Person("Lilja", 26);
            Person num3 = new Person("Oliver", 18);
            Person num4 = new Person("James", 31);

            People.Add(Num1);
            People.Add(Num2);
            People.Add(num3);
            People.Add(num4);

            Console.WriteLine("People in list of people: ");

            foreach (var Person in People)
            {
                Console.WriteLine($"\tName: {Person.Name} \n\tAge: {Person.Age}");
            }




        }






    }
}
