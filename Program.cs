

using Opdracht1;

var people = new List<Person>
{
    new Student
    {
        FirstName = "Asaad",
        LastName = "Asaad",
        Age = 30,
    },
    new Student
    {
        FirstName = "Ahmd",
        LastName = "Ahmd",
        Age = 25,
    },
    new Teacher
    {
        FirstName = "Wannes",
        LastName = "Gennar",
        Age = 25,
        Subjects = new []{".Net advance", ".Net frameworks",},
    },

};

foreach (var person in people)
{
    Print(person);
}






void Print(Person person)
{
    Console.WriteLine($"{person.GetFullName()} {person.Age}");
}


void AssignName(Person person)
{
    while (string.IsNullOrWhiteSpace(person.FirstName))
    {
        Console.Write("Enter your first name: ");
        person.FirstName = Console.ReadLine() ?? String.Empty;
    }
}
