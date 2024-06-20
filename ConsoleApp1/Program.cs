// See https://aka.ms/new-console-template for more information

Dictionary<int, string> names = new Dictionary<int, string>()
{
    {1, "Aba"},
    {2, "Test"},
    {3, "Test2"}
};

names.Add( 4, "Aba");

for (int i = 0; i < names.Count; i++)
{
   KeyValuePair<int, string> pair = names.ElementAt(i);
   Console.WriteLine($"{pair.Key}: {pair.Value}");
}
Console.WriteLine(string.Join(", ", names));

Console.WriteLine(names[1]); //gets the value at the key given (search)


if (names.TryGetValue(5, out string name)) //alternatively names.ContainsKey(5)
{
    Console.WriteLine(name);
}
else {
    Console.WriteLine("Not found");
}

