




// Отбор строк
string [] StringFilter(string [] stringsArray, int min)
{
    int position = 0;
    string[] newArray = new string[0];
    for (int i = 0; i<stringsArray.Length; i++)
    {
        if (stringsArray[i].Length < min)
        {
            Array.Resize(ref newArray, position+1);
            newArray[position] = stringsArray[i];
            position++;
        }
    }

    return newArray;
}

// Печать массива
void PrintArray(string [] arr)
{
    Console.Write("[");
    Console.Write(String.Join(", ", arr));
    Console.Write("]");
}
