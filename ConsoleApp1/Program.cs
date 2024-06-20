// See https://aka.ms/new-console-template for more information

int[] numbers = new int[] 
{
 9, 8, 7, 6, 5, 4, 3, 2, 1
};

List<int> listEmpty = new List<int>();
List<int> listDefault = new List<int>(3);
List<int> listColl = new List<int>(); //Can also add another collection
List<int> listNums = new List<int>()
{
    1, 2, 3, 4
};


listNums.Add(1);
listNums.Add(2);
listNums.Add(3);
listNums.Add(4);

for(int i =0; i < listNums.Count; i++){
    Console.Write(listNums[i] + ", ");
}
Console.WriteLine();

Console.WriteLine(string.Join(", ", listNums));

