// See https://aka.ms/new-console-template for more information


//.NEt 6+ since this IS main and not the class 
// how do we define class variables for THIS class?
// https://youtu.be/YrtFtdTTfv0?si=TZTAaLvlkKQxzn9o&t=16940

// in all your class fucntions you also want to use the Properties (whyy???) 
// youre within the scope of the private variables why not just use them?

//main:
using System.Reflection.Metadata.Ecma335;

Person person = new Person("Aba", 23, 5);
person.PrintDetails(); //object.Method()

// person.Name= "Henery";
// Console.WriteLine($"{person.Name} ");

// no longer allowed with private fields

//using getters and setters
person.setName("Henry");
Console.WriteLine($"{person.getName()} ");

//using properties
person.Name = "Gerald";
Console.WriteLine($"{person.Name} ");

class Person
{
    private string name; 
    private int age;
    private int birthMonth; // i lied fields are REGULAR camel Case

    public string Name
    {
        get => this.name;
        set => this.name = value;
    }

    public string UserName {get; set;}
    // just creating a property C will create a matching private variable 
    // with default getter and setter 
    // so you dont need to initialize a userName seperatley

    //contructor
    public Person(string name, int age, int birthMonth)
    {
        this.Name = name;
        //convention is also to make the fields Capital Camel
        age = age;
        birthMonth = birthMonth;

    }

    //also a constructor
    public Person(){}

    // in all your other class fucntions you also want to use the Properties (whyy???)

    public string PrintDetails(){
        Console.WriteLine($"Name: {Name}");  // using the property ***
        Console.WriteLine($"Age: {this.age}");
        Console.WriteLine($"Birth Month: {this.birthMonth}");

        return "success";
    }

    // dont actually use these 
    public void setName(string name) => this.name = name;
    public string getName() => this.name;
    public int GetAge() => this.age; //shorthand
}


