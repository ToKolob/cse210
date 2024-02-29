using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string numberAux;
        int number = 0;
        List<int> numbers = new List<int>();
        int sum = 0;
        float average = 0;
        int max = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            numberAux = Console.ReadLine();
            number = int.Parse(numberAux);
            numbers.Add(number);
        } while (number != 0);
        
        //the sum of all the numbers
        foreach (int num in numbers){
            sum += num;
        }


        //the average
        average = sum / (numbers.Count - 1);

        //the max
        foreach (int num in numbers){
            if (num > max){
                max = num;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max is: {max}");       

        
    }
}