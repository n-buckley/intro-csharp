// See https://aka.ms/new-console-template for more information

/* Create a for loop 1 to X (15)
* 3 and 5 = FizzBuzz 
* 3 = Fizz, 5 = Buzz (if divisible)
* else = itself
*/

for (int i = 1; i <=15; i++){
    if (i % 3 == 0 && i % 5 == 0){
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0 ){
        Console.WriteLine("Fizz");
    }
    else if ( i % 5 == 0){
        Console.WriteLine("Buzz");
    }
    else {
        Console.WriteLine(i);
    }
}