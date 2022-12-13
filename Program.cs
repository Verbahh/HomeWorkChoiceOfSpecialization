string[] originalArray = {}; // Задание проверяемого массива в коде

void showArray(string[] array)        //вывод массива
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\"");
        if (i + 1 != array.Length)
        {
            Console.Write(", ");
        }
    }
    Console.Write(" ]");
}

string[] getInputArray()            //запрашивает массив строк
{
    Console.Write("Input length array: ");
    int length = Convert.ToInt32(Console.ReadLine());
    string[] outArray = new string[length];
    int i = 0;
    Console.WriteLine("Input string to array:");
    while (i < length)
    {
        string inp;
        if ((inp = Console.ReadLine()) != null)
        {
            outArray[i] = inp;
        }
        i++;
    }
    return outArray;
}

string[] arrayValidation(string[] array)               //переделывает массив под условие
{
    int count = 0;
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    
    string[] outArray = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            outArray[index] = array[i];
            index++;
        }
    }
    return outArray;
}


string[] array;
if (originalArray.Length > 0)
{
    array = originalArray;
}
else {
    array = getInputArray();
}
string[] resultArray = arrayValidation(array);
showArray(resultArray);