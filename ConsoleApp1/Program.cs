// See https://aka.ms/new-console-template for more information

int[] angles = new int[3]; //makes array of size 3

angles[0] = 0;
angles[1] = 1; 
angles[2] = 2;

//angles.Length

foreach (int n in angles){

    Console.Write(n + " ");
}
Console.WriteLine();

int[] numbers = new int[] 
{
 9, 8, 7, 6, 5, 4, 3, 2, 1
};

Array.Sort(numbers); //mutates -- i forget the term...
Console.WriteLine(string.Join(",", numbers));

Array.Reverse(numbers);
Console.WriteLine(string.Join(",", numbers));

// Array.Clear(numbers); //sets all values to default of the data type
Array.Clear(numbers, 5, 4); // clears values starting at index 5 + 4
Console.WriteLine(string.Join(",", numbers));

Console.WriteLine(Array.IndexOf(numbers, 0)); //can also substring , start index, last index 