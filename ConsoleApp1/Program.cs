// See https://aka.ms/new-console-template for more information

bool isPink = true;
Console.WriteLine(isPink);

int age = 23; 
age++;
// age = age + 1;
// age += 1
age--;

string name = "Aba";
string rest = "is programming";
name += rest;

char a = 'a';
a += 'b';
// will add the unicode values together, and result in the character at that unicode value

int i = 0;
Console.WriteLine(i++); //addition will execute AFTER print to console
Console.WriteLine(++i); //addition executes BEFORE print

// % is the same 

Console.ReadLine();
