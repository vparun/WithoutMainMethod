using Personal;

Console.WriteLine("Hello, World!");

var name = "Arun";

// Object creating
var person = new Person("Arunkumar");

// Display
Print("HI ");

PrintName("Hi ");

// Functions
void Print(string text) => Console.WriteLine(text + " " + name);

void PrintName(string text) => Console.WriteLine(text + " " + person.Name);


namespace Personal
{
    public class Person
    {
        public string Name { get; }
        public Person(string name) => Name = name;
    }
}