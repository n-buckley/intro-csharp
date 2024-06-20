// See https://aka.ms/new-console-template for more information


//.NEt 6+ since this IS main and not the class 
// how do we define class variables for THIS class?
// https://youtu.be/YrtFtdTTfv0?si=TZTAaLvlkKQxzn9o&t=16940

//main:
Console.Title = ReturnName();
WelcomeMessage();
Test.something();

Test test = new Test();
test.somethingElse();





static void WelcomeMessage(){ //looks like standard is CapitalCamelCase
    // void doesnt return
    Console.WriteLine($"Welcome {ReturnName()}");
}

static string ReturnName(){ 
    //returns a string
    return "Joe";
}

class Test
{
    public static void something(){
        Console.WriteLine("soemthing");
    }

    public void somethingElse(){
        Console.WriteLine("soemthing else");

    }
}