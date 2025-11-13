using Aoc.Year2024.Day01;

string input = GetInput.Run();

DateTime startedAt = DateTime.Now;
int result = Part01.Run(input);
TimeSpan elapsed = DateTime.Now - startedAt;
Console.WriteLine("part_one={0}, run_time={1}", result, elapsed);

startedAt = DateTime.Now;
result = Part02.Run(input);
elapsed = DateTime.Now - startedAt;
Console.WriteLine("part_two={0}, run_time={1}", result, elapsed);
