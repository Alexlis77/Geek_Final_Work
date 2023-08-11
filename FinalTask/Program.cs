/*
Задача: 
Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.

При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

int EnterMethod(string textOut) // Метод ввода параметра максимального количества элементов в строке
{
    Console.Write(textOut);
    int numberIn = Convert.ToInt32(Console.ReadLine());
    return numberIn;
}

// Метод выборки строк длиной не болле заданной и последующего сохранения в новый массив 
string[] CreateNewStringArray(string[] arr, int maxNumChar)   
{
    int num = 0;
    int temp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        temp = arr[i].Length;
        if (temp <= maxNumChar) num = num + 1;
    }

    string[] newArray = new string[num];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        temp = arr[i].Length;
        if ( temp <= maxNumChar) 
        {
            newArray[j] = arr[i];
            j++;
        }
    }
    return newArray;
}

void PrintArray(string[] arrayToPrint) // Метод вывода массива строк в консоль терминала
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("[");
    Console.ForegroundColor = ConsoleColor.White;
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write("\"" + $"{arrayToPrint[i]}" + "\"");
        if (i < arrayToPrint.Length - 1) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(", ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("]");
    Console.ForegroundColor = ConsoleColor.White;
}

string[] EnterStringArray() // Метод получения массива строк от пользователя
{
string[] StringArray;
int count;
string s;
string[] ArrayTemp;

Console.WriteLine("Вводите строки:");

count = 0;
StringArray = new string[count];

do // Вводятся строки, пока не будет введена пустая
{
    s = Console.ReadLine()!;
    if (s!="")
    {
        count++;
        ArrayTemp = new string[count];
        for (int i = 0; i < ArrayTemp.Length - 1; i++)
            ArrayTemp[i] = StringArray[i];

        ArrayTemp[count - 1] = s;
        StringArray = ArrayTemp;
    }
} while (s != "");
return StringArray;
}

Console.Clear();

int number = EnterMethod("Введите максимальное число символов в строке: ");
string[] StrArray = EnterStringArray();
string[] NewArray = CreateNewStringArray(StrArray, number);

PrintArray(StrArray);
Console.Write(" -> ");
PrintArray(NewArray);
Console.WriteLine();
