using Aoc.Year2015.Day01;

string input = GetInput.get_input();

DateTime startedAt = DateTime.Now;
int result = Part01.part_01(input);
TimeSpan elapsed = DateTime.Now - startedAt;
Console.WriteLine("part_one={0}, run_time={1}", result, elapsed);

startedAt = DateTime.Now;
result = Part02.part_02(input);
elapsed = DateTime.Now - startedAt;
Console.WriteLine("part_two={0}, run_time={1}", result, elapsed);
