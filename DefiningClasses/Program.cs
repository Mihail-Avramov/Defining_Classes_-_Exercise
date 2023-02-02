namespace DefiningClasses
{
    public class StartUp

    {
        static void Main()
        {
            Family newFamily = new Family();

            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                Person newPerson = new Person(name, age);

                newFamily.AddMember(newPerson);
            }

            Person person = newFamily.GetOldestMember();
            Console.WriteLine($"{person.Name} {person.Age}");
        }
    }
}