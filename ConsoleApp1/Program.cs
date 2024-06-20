// See https://aka.ms/new-console-template for more information


//.NEt 6+ since this IS main and not the class 
// how do we define class variables for THIS class?
// https://youtu.be/YrtFtdTTfv0?si=TZTAaLvlkKQxzn9o&t=16940

// in all your class fucntions you also want to use the Properties (whyy???) 
// youre within the scope of the private variables why not just use them?

//main:
using System.Reflection.Metadata.Ecma335;

Person person = new Person("Aba", 23);
person.PrintDetails();
Console.WriteLine($"{person} ");

Person person2 = new Person("Aba", 23);
Person person3 = new Person("Aba!", 23);

Console.WriteLine($"{person.Equals(person2)} ");    // without updating .Equals should be False
                                                    // after updating should be True

Console.WriteLine($"{person.Equals(person3)} ");    // should be false before AND after override



class Person
{
    public string Name {get; set;}
    public int Age {get; set;}



    //contructor
    public Person(string name, int age)
    {
        Name = name;
        //convention is also to make the fields Capital Camel
        Age = age;

    }

    //also a constructor
    public Person(){}


    public string PrintDetails(){
        Console.WriteLine($"Name: {Name}");  
        Console.WriteLine($"Age: {Age}");

        return "success";
    }

    public override string ToString()
    {
        return $"Name: {Name}\nAge: {Age}";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Person) //type checking
        {
            Person p = obj as Person; //type casting
            return Name.Equals(p.Name) && Age == p.Age; 
        }
        return false;
    }
}


