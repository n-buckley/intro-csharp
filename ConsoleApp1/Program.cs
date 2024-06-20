// See https://aka.ms/new-console-template for more information


//.NEt 6+ since this IS main and not the class 
// how do we define class variables for THIS class?
// https://youtu.be/YrtFtdTTfv0?si=TZTAaLvlkKQxzn9o&t=16940

//main:

try
{
    Console.WriteLine("Eter a number:");
    int num = Convert.ToInt32(Console.ReadLine());
    // if enter number too big (over 9000000000) will throw exception

    Console.WriteLine(num);


}
catch (FormatException)
{
    Console.WriteLine("Not an int");
}
catch (OverflowException)
{
    Console.WriteLine("Integer entered was too big");
}
catch (Exception e)  //will catch every exception 
{
    Console.WriteLine("Something went wrong");
    Console.WriteLine(e.Message);

}