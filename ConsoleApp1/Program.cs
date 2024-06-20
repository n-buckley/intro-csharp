// See https://aka.ms/new-console-template for more information


//.NEt 6+ since this IS main and not the class 
// how do we define class variables for THIS class?
// https://youtu.be/YrtFtdTTfv0?si=TZTAaLvlkKQxzn9o&t=16940

//main:
using System.Reflection.Metadata.Ecma335;

Person person = new Person("Aba", 23, 5);
person.PrintDetails(); //object.Method()

// person.Name= "Henery";
// Console.WriteLine($"{person.Name} ");

// no longer allowed with private fields

person.setName("Henry");
Console.WriteLine($"{person.getName()} ");

class Person
{
    private string Name; 
    private int Age;
    private int BirthMonth;

    //contructor
    public Person(string name, int age, int birthMonth)
    {
        this.Name = name;
        //convention is also to make the fields Capital Camel
        Age = age;
        BirthMonth = birthMonth;

    }

    //also a constructor
    public Person(){}

    public string PrintDetails(){
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Birth Month: {BirthMonth}");

        return "success";
    }

    public void setName(string name)
    {
        //check fo validity here 
        Name = name;
    }

    public string getName()
    {
        return Name;
    }

    public int GetAge() => Age; //shorthand
}


