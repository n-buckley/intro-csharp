// See https://aka.ms/new-console-template for more information

using System.Runtime.Intrinsics.Arm;

Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("What id your age: ");
string ageInput = Console.ReadLine();
int age = Convert.ToInt32(ageInput);

Console.WriteLine("Your name is " + name + " and your age is " + age);

// == > >= < <= ! || &&
if (age < 0 || age > 150){
    Console.WriteLine("Invalid age");
}
else {
    if (age >= 18 && age < 25){
        Console.WriteLine("You are 18 or older");
    }
    else if (age >= 25) {
        Console.WriteLine("You are 25 or older");

    }
}

Console.Write("Enter a number: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter another number: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.Write("What is " + numA + " times " + numB + ": ");
int answerInput = Convert.ToInt32(Console.ReadLine());

int answer = numA * numB;
if (answer == answerInput) {
    Console.WriteLine("Correct");
}
else {
    Console.WriteLine("No");
}