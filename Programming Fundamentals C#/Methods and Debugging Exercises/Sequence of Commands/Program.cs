using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        while (true)
        {
            var input = Console.ReadLine();

            if (input.Equals("stop"))
            {
                break;
            }

            var commands = input.Split();
            var action = commands[0];
            var index = 0;
            var value = 0;

            if (commands.Length > 1)
            {
                index = int.Parse(commands[1]);
                value = int.Parse(commands[2]);
            }

            var args = new int[] { index, value };
            PerformAction(array, action, args);
        }
    }

    static void PerformAction(long[] arr, string action, int[] args)
    {
        int pos = args[0];
        int value = args[1];

        switch (action)
        {
            case "multiply":
                arr[pos - 1] *= value;
                break;
            case "add":
                arr[pos - 1] += value;
                break;
            case "subtract":
                arr[pos - 1] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(arr);
                break;
            case "rshift":
                ArrayShiftRight(arr);
                break;
        }

        PrintArray(arr);
    }

    private static void ArrayShiftRight(long[] array)
    {
        var lastElement = array[array.Length - 1];

        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }

        array[0] = lastElement;
    }

    private static void ArrayShiftLeft(long[] array)
    {
        var firstElement = array[0];

        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }

        array[array.Length - 1] = firstElement;
    }

    private static void PrintArray(long[] array)
    {
        Console.WriteLine(string.Join(" ", array));
    }
}
