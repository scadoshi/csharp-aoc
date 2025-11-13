using Aoc.Year2024.Day01;

DateTime startedAt = DateTime.Now;
int result = Part01.Run(GetInput.Run());
TimeSpan elapsed = DateTime.Now - startedAt;
Console.WriteLine("part_one={0}, run_time={1}", result, elapsed);

startedAt = DateTime.Now;
result = Part02.Run(GetInput.Run());
elapsed = DateTime.Now - startedAt;
Console.WriteLine("part_two={0}, run_time={1}", result, elapsed);
