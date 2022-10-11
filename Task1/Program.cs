
// ---------------------------------------------------------------------
//                                 Задача 1
// Напишите программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатурыб либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциямиб лучше обойтись исключительно массивами.
// ---------------------------------------------------------------------

// Чтение данных из консоли
string ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем и Возвращаем данные
    return Console.ReadLine() ?? "0";
}

// обрабатываем входящие данные
string[] ParceReadData(string line)
{
    // Убираем лишние элементы
    line = line.Replace(" ", "");
    line = line.Replace("]", "");
    line = line.Replace("[", "");
    line = line.Replace("\"", "");
    // Разбиваем строку на массив по запятой
    string[] parcedLine = line.Split(",");
    return parcedLine;
}

// Создаём массив с необходимыми данными
string[] ChangeArray(string[] parcedLine)
{
    int temp = 0;
    // Считаем количество необходимых элементов
    for (int i = 0; i < parcedLine.Length; i++)
    {
        if (parcedLine[i].Length <= 3)
        {
            temp++;
        }
    }

    // Задаём длину массива равную количеству необходимых элементов
    string[] finalArray = new string[temp];
    int j = 0;
    // Заполняем массив
    for (int i = 0; i < parcedLine.Length; i++)
    {
        if (parcedLine[i].Length <= 3)
        {
            finalArray[j] = parcedLine[i];
            j++;
        }
    }
    return finalArray;
}

// печатаем массив
void PrintArray(string[] arr)
{
    Console.Write("[");
    // Рассматриваем частный случай, когда массив пуст
    if (arr.Length == 0)
    {
        Console.Write("]");
    }
    else
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.Write(arr[arr.Length - 1] + "]");
    }
    Console.WriteLine();
}

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

string array1 = "hello, 2, world, :-)";
string array2 = "1234, 1567, -2, computer sciense";
string array3 = "Russia, Denmark, Kazan";

PrintResult(array1);
PrintArray(ChangeArray(ParceReadData(array1)));

PrintResult(array2);
PrintArray(ChangeArray(ParceReadData(array2)));

PrintResult(array3);
PrintArray(ChangeArray(ParceReadData(array3)));


// Для ввода с клавиатуры:
// ["hello", "2", "world", ":-)"]
// ["1234", "1567", "-2", "computer sciense"]
// ["Russia", "Denmark", "Kazan"]

PrintArray(ChangeArray(ParceReadData(ReadData("Введите массив: "))));