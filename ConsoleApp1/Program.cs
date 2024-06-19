// See https://aka.ms/new-console-template for more information


using System.Globalization;

double value = 1000D / 12.34D;
Console.WriteLine(value); // ugly 

Console.WriteLine(string.Format("{0}, {1}",value, 1000)); // still ugly

Console.WriteLine(string.Format("{0:0.00}", value)); //pretty, will round
Console.WriteLine(string.Format("{0:0.00}", value)); //pretty, will round
Console.WriteLine(string.Format("{0:0.0}", value)); //pretty, will round
Console.WriteLine(string.Format("{0:0.#}", value)); //gets rid of trailing zero

double money = 10D / 3D; 
Console.WriteLine(string.Format("${0:0.00}", money)); //works for positive numbers
money *= -1D;
Console.WriteLine(string.Format("${0:0.00}", money)); //not for negative (negative sign is after $ sign, should be before)
Console.WriteLine(money.ToString("C")); //C = currency
Console.WriteLine(money.ToString("C0")); //C0 = no decimal
Console.WriteLine(money.ToString("C1")); //C1 = 1 decimal
Console.WriteLine(money.ToString("C2")); //C2 = 2 decimal

Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

