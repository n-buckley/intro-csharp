// See https://aka.ms/new-console-template for more information


//.NEt 6+ since this IS main and not the class 
// how do we define class variables for THIS class?
// https://youtu.be/YrtFtdTTfv0?si=TZTAaLvlkKQxzn9o&t=16940

//main:
Person person = new Person("Aba", 23, 5);

Console.WriteLine($"{person.Name} - {person.Age} - {person.BirthMonth}");

// more useful for simple custom datatypes
// struct Person
// {
//     // private string SSN;
//     // string SSN;
//     public string Name; 
//     public int Age;
//     public int BirthMonth;

//     //contructor
//     public Person(string name, int age, int birthMonth)
//     {
//         this.Name = name;
//         //convention is also to make the fields Capital Camel
//         Age = age;
//         BirthMonth = birthMonth;

//     }
// }

// ^ ---  main difference is you can leave a Class constructor/fields empty  ---- v 
// more useful for complicated fucntions, and flexibility.
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
}


