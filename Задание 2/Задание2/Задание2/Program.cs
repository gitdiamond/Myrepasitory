

/*Console.Write("Введите массив строк, используя пробел:");
string[] array;
string array = Console.ReadLine();
array = array.Split(' ');
string result = new string[array.Length];
string realSize = 0;

foreach (string s in array)
{
    if(s.Length <=3)
    {
        result[realSize] = s;
        realSize++;
    }
}

Console.WriteLine(string.Join(result, 0, realSize));
Console.WriteLine(true);*/

string[] text;
Console.WriteLine("Введите массив строк через запятую");
string array = Console.ReadLine();
text = array.Split(' ');
var result = new string[text .Length];
var realSize = 0;
foreach (var findi in text )
{
    if (findi.Length <= 3)
    {
        result[realSize] = findi;
        realSize++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
Console.ReadKey(true);