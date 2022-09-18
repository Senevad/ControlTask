Console.Clear();

Console.WriteLine("Введите 5 строк");
string [] stringArray = new string [5];
for (int i = 0; i < stringArray.GetLength(0); i++)
{
    stringArray[i] = Console.ReadLine()!;
}
