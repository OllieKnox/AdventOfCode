using System.Diagnostics;
using AdventOfCode.Helpers;
using AdventOfCode.Y24.D1;

var lines = InputReader.ReadInput(@"Y24/D1/Input.txt");
var input = new Input();

lines.ForEach(line =>
{
    var parsedLine = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    Debug.Assert(parsedLine.Length == 2); 

    input.Left.Add(int.Parse(parsedLine[0]));
    input.Right.Add(int.Parse(parsedLine[1]));
});

Part1();
Part2();

void Part1()
{
    Console.WriteLine("2024 | Day 1 | Part 1");

    input.Left.Sort();
    input.Right.Sort();

    Debug.Assert(input.Left.Count == input.Right.Count);

    var distances = new List<int>();

    for (var i = 0; i < input.Left.Count; i++)
    {
        var left = input.Left[i];
        var right = input.Right[i];
        var distance = Math.Abs(left - right);
        distances.Add(distance);
    }

    var sum = distances.Sum();

    Console.WriteLine($"Answer: {sum}");
}

void Part2()
{
    Console.WriteLine("2024 | Day 1 | Part 2");

    var countPerLocation = new Dictionary<int, int>();

    input.Left.ForEach(location =>
    {
        countPerLocation.Add(location, 0);
    });

    input.Right.ForEach(location =>
    {
        if (countPerLocation.TryGetValue(location, out var count))
        {
            countPerLocation[location]++;
        }
    });

    var sum = input
        .Left
        .Select(location =>  location * countPerLocation[location])
        .Sum();

    Console.WriteLine($"Answer: {sum}");
}