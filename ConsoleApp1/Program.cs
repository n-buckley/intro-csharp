// See https://aka.ms/new-console-template for more information


//.NEt 6+ since this IS main and not the class 
// how do we define class variables for THIS class?
// https://youtu.be/YrtFtdTTfv0?si=TZTAaLvlkKQxzn9o&t=16940

//main:

Person person; 
person.name = "Aba";
person.age = 23;
//cannot set or access SSN bc private, defualt is private

Console.WriteLine($"{person.name} - {person.age}");

person = ConsolePerson();
Console.WriteLine($"{person.name} - {person.age}");


static Person ConsolePerson(){
    Console.Write("What is uur name: ");
    string name = Console.ReadLine();

    Console.Write("What is uur name: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.Write("What is uur nabirth monthme: ");
    int birth = Convert.ToInt32(Console.ReadLine());
    

    // Person p; 
    // p.name = name;
    // p.age = age;
    // p.birthMonth = birth;
   

    return p;
}

struct Person
{
    // private string SSN;
    // string SSN;
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
}



