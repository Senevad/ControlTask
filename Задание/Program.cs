Console.Clear();

Console.WriteLine("Введите 5 строк");
int count = 0;
string [] stringArray = new string [5];
for (int i = 0; i < stringArray.GetLength(0); i++)
{
    stringArray[i] = Console.ReadLine()!;
    if (stringArray[i].Length <= 3)
    {
        count++;
    }
}

string [] needStringArray = new string [count];
int temp = 0;
for (int i = 0; i < stringArray.GetLength(0); i++)
{
    if (stringArray[i].Length <= 3)
    {
        needStringArray[temp] = stringArray[i];
        temp++;
    }
}

    Console.Write($"Итоговый Массив: {String.Join(",",needStringArray)}");

