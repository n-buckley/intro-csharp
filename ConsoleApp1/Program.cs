// See https://aka.ms/new-console-template for more information

Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("What id your age: ");
string ageInput = Console.ReadLine();
int age = Convert.ToInt32(ageInput);

Console.WriteLine("Your name is " + name + " and your age is " + age);
