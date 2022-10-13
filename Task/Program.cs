void FillArrayFromConsole(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
}

string[] CreateNewStringArray(string[] array)
{
    string[] result = new string[array.Length];
    int newSizeForResultArray = 0; 
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newSizeForResultArray++;
            result[j] = array[i];
            j++;
        }
    }
    Array.Resize(ref result, newSizeForResultArray);
    return result;
}

System.Console.Write("Сколько элементов будет в массиве? ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
FillArrayFromConsole(array);
string[] result = CreateNewStringArray(array);
System.Console.WriteLine("[{0}]", string.Join(", ", result));