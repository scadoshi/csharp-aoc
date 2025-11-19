using CSharpAoc.Year2015.Day02;

DateTime startedAt = DateTime.Now;
var result1 = Part01.Run(GetInput.Run());
TimeSpan elapsed = DateTime.Now - startedAt;
Console.WriteLine("part_one={0}, run_time={1}", result1, elapsed);

startedAt = DateTime.Now;
var result2 = Part02.Run(GetInput.Run());
elapsed = DateTime.Now - startedAt;
Console.WriteLine("part_two={0}, run_time={1}", result2, elapsed);
