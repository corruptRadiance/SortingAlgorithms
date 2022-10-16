using System.Diagnostics;
using Sorting;

TimeSpan time = TimeSpan.Zero;
Stopwatch sw = new Stopwatch();

Console.Clear();

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Number of arrays to generate/sort: ");
Console.ForegroundColor = ConsoleColor.White;
int arrayCount = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("\nLength of each array: ");
Console.ForegroundColor = ConsoleColor.White;
int arrayLength = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("\nMax integer (0-index): ");
Console.ForegroundColor = ConsoleColor.White;
int max = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Cyan;

for (int t = 0; t < arrayCount; t++)
{
    // Create empty array, fill it with random integers given parameters
    int[] toSort = new int[arrayLength];

    Console.Write("\nUnsorted list: ");
    for (int i = 0; i < arrayLength; i++)
    {
        toSort[i] = Random.Shared.Next(max);
        Console.Write(toSort[i]);
    }

    // Pass array to Sort method
    sw.Restart();
    int[] sorted = Sort.Bubble(toSort);
    sw.Stop();

    Console.Write("\nSorted list: ");
    foreach (int element in sorted)
    {
        Console.Write(element);
    }
    Console.WriteLine();

    // Console.Write($"\nTime elapsed: {sw.Elapsed}\n");
    time += sw.Elapsed;
}

Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"\nTotal time: {time}");
Console.Write($"\nAverage time: {time / arrayCount}");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("\n\nPress any key to exit.");
Console.ReadKey(true);
Console.ForegroundColor = ConsoleColor.White;