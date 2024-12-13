string[] lines = File.ReadAllLines(@"C:\Users\yvesg\git\aoc2019\03\test2.txt");
(int, int)[] directions = [(-1, 0), (0, -1), (0, 1), (1, 0)];

void part1()
{
  HashSet<(int, int)> crosses = new HashSet<(int, int)>();
  HashSet<(int, int)> wires = new HashSet<(int, int)>();

  lines.ToList().ForEach(l =>
  {
    int x = 1, y = 1;
    var L = l.Split(',').ToList();
    L.ForEach(ll =>
    {
      string D = ll[0].ToString();
      var (dy, dx) = directions[(int)(Direction)Enum.Parse(typeof(Direction), D)];
      int nb = int.Parse(ll.Substring(1));
      // Console.WriteLine($"D {D} dy {dy} dx {dx} nb {nb}");
      Enumerable.Range(0, nb - 1).ToList().ForEach(i =>
      {
        y += dy;
        x += dx;
        if (wires.Contains((y, x)))
        {
          crosses.Add((y, x));
        }
        wires.Add((y, x));
      });

    });
  });
  crosses.ToList().ForEach(p =>
  {
    Console.WriteLine($"{p.Item1} {p.Item2}");
  });
  {

  }
}

void part2()
{


}
part1();
part2();

public struct Dir
{
  public char D { get; set; }
  public int L { get; set; }

  public Dir(char d, int l)
  {
    D = d;
    L = l;
  }
}



enum Direction
{
  U,
  L,
  R,
  D
}
