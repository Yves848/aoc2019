List<int> masses = File.ReadAllText(@"C:\Users\yvesg\git\aoc2019\01\data.txt").Split("\r\n").ToList().Select(p => int.Parse(p)).ToList();

void part1()
{
  int total = 0;
  masses.ForEach(mass =>
  {
    total += ((int)Math.Floor((decimal)mass / 3) - 2);
  });
  Console.WriteLine(total);
}

void part2()
{
  int total = 0;
  masses.ForEach(mass =>
  {
    int m = ((int)Math.Floor((decimal)mass / 3) - 2);
    while (m > 0) {
      total += m;
      m = ((int)Math.Floor((decimal)m / 3) - 2);
    }
    
  });
  Console.WriteLine(total);
}

part1();
part2();