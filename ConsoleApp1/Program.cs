// See https://aka.ms/new-console-template for more information


//.NEt 6+ since this IS main and not the class 
// how do we define class variables for THIS class?
// https://youtu.be/YrtFtdTTfv0?si=TZTAaLvlkKQxzn9o&t=16940

//main:
using System.Runtime.InteropServices;

Console.WriteLine(Add(5, 5));
Console.WriteLine(Add(5));

//optional paramaters
static int Add(int a, int b = default)
{
    return a + b;
}
//does the same thing as int b = default
// static int Add(int a, [Optional] int b)
// {
//     return a + b;
// }


string nameIn = "Aba";
int ageIn = 23;
string addyIn = "1 Hilton Rd";

//correct order
PrintDetails(nameIn, ageIn, addyIn);

//incorect order using named paramaters still works
PrintDetails(age:ageIn,
             name:nameIn,
             addy:addyIn);


static void PrintDetails(string name, int age, string addy)
{
    Console.WriteLine($"Name: {name}");
    Console.WriteLine($"Age: {age}");
    Console.WriteLine($"Address: {addy}");

}

//out parameters
int num = 0;
Console.WriteLine(num); //prints 0
// can ommit above lines and do this instead
//test(out int num);

test(out num); //mutates num/the variable passed in


static bool test(out int num){
    num = 5; 
    return true;
}
Console.WriteLine(num); //print 5

//reference parameters (ref param)
//c flash backs

int numBooks = 5;
Console.WriteLine(numBooks);
Assign(ref numBooks);

static void Assign(ref int num){
    num = 20; //also mutates (uts 20 at the passed address in memory)
}
Console.WriteLine(numBooks);
