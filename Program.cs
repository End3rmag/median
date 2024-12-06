using System;
using System.Collections.Generic;

var medianFinder = new MedianFinder();

Console.WriteLine("Введите целые числа для получения медианы. Введите 'exit' для выхода ");

while (true)
{
    string input = Console.ReadLine();
    if (input.ToLower() == "exit")
    {
        break;
    }
    string[] parts = input.Split(' ');
    bool trueInput = true;

    foreach (var part in parts)
    {
        if (int.TryParse(part, out int number))
        {
            medianFinder.AddNum(number);
        }
        else
        {
            Console.WriteLine($"'{part}' не является корректным целым числом.");
            trueInput = false;
            break;
        }
    }
    if (trueInput)
    {
        double median = medianFinder.FindMedian();

        Console.WriteLine($"Текущая медиана: {median}");
    }
}
public class MedianFinder
{
    private List<int> numbers;

    public MedianFinder()
    {
        numbers = new List<int>();
    }

    public void AddNum(int num)
    {
        numbers.Add(num);
        numbers.Sort();
    }

    public double FindMedian()
    {
        int n = numbers.Count;
        if (n % 2 == 0)
        {
            return (numbers[n / 2 - 1] + numbers[n / 2]) / 2.0;
        }
        else
        {
            return numbers[n / 2];
        }
    
    }
}


