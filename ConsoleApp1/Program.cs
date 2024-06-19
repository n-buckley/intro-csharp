// See https://aka.ms/new-console-template for more information

/* Create a for loop 1 to X (15)
* 3 and 5 = FizzBuzz 
* 3 = Fizz, 5 = Buzz (if divisible)
* else = itself
*/

string name = "Aba";
int age = 23;

string interpolation = $"ur name is {name} and ur age is {age}";
Console.WriteLine( interpolation);


for (int i = 0; i < interpolation.Length; i++){
    Console.Write(interpolation[i] );
    // python-like substring/indexification of strings
    // i am making up words
    System.Threading.Thread.Sleep(100); // fun text output :D
}
Console.WriteLine();

Console.WriteLine(interpolation.Contains("u")); 

string n = null;

if (!string.IsNullOrEmpty(n))
    Console.WriteLine("use this!");