using System;

class Program
{
    static void Main()
    {
        // Введите строки в массив
        Console.Write("Введите строки через запятую: ");
        string input = Console.ReadLine();
        string[] originalArray = input.Split(',');

        // Фильтруем строки
        string[] filteredArray = FilterStrings(originalArray);

        // Выводим результат
        Console.WriteLine("Отфильтрованный массив:");
        foreach (string str in filteredArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterStrings(string[] inputArray)
    {
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] resultArray = new string[count];
        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }

        return resultArray;
    }
}
