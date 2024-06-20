// See https://aka.ms/new-console-template for more information


//.NEt 6+ since this IS main and not the class 
// how do we define class variables for THIS class?
// https://youtu.be/YrtFtdTTfv0?si=TZTAaLvlkKQxzn9o&t=16940

//main:
Person person = new Person("Aba", 23, 5);

// Console.WriteLine($"{person.Name} - {person.Age} - {person.BirthMonth}");
person.PrintDetails(); //object.Method()

class Person
{
    public string Name; 
    public int Age;
    public int BirthMonth;

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
}


