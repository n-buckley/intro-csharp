// See https://aka.ms/new-console-template for more information

Console.Write("Enter day of the week (1-7): ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day) 
{

    case 1: Console.WriteLine("Mon");
        break; // Need to include for syntax
    case 2: Console.WriteLine("Tues");
        break; 
    case 3: Console.WriteLine("Wed");
        break; 
    case 4: Console.WriteLine("Thur");
        break; 
    case 5: Console.WriteLine("Fri");
        break; 
    case 6: Console.WriteLine("Sat");
        break; 
    case 7: Console.WriteLine("Sun");
        break;
    default: Console.WriteLine("Enter value between 1 and 7");
        break;

    // can chain by doing
    // case 1:
    // case 2: Console.WriteLine("1 and 2 will ahve the same print statemnt");
    //     break;


}
