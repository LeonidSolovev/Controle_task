
string[] initialArray = new string[] {GetUserInput("Введите первое значение: "), GetUserInput("Введите второе значение: "),
 GetUserInput("Введите третье значение: ")};

string[] result = StringFilter(initialArray, 3);
PrintArray(initialArray);
Console.Write("->");
PrintArray(result);

// Отбор строк
string[] StringFilter(string[] stringsArray, int min)
{
    int position = 0;
    string[] newArray = new string[0];
    for (int i = 0; i < stringsArray.Length; i++)
    {
        if (stringsArray[i].Length <= min)
        {
            Array.Resize(ref newArray, position + 1);
            newArray[position] = stringsArray[i];
            position++;
        }
    }

    return newArray;
}
// Печать массива
void PrintArray(string[] arr)
{
    Console.Write("[");
    Console.Write(String.Join(", ", arr));
    Console.Write("]");
}

// Ввод данных через консоль
string GetUserInput(string message)
{
    Console.Write(message);
    string userMessage = Console.ReadLine();
    return userMessage;
}

