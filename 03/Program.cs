using System.Collections;
using System.Security.Cryptography.X509Certificates;

string[] lines = File.ReadAllLines(@"C:\Users\yvesg\git\aoc2019\03\data.txt");
// U, L, R, D
(int, int)[] directions = [(0, 1), (-1, 0), (1, 0), (0, -1)];

void part1()
{
  HashSet<(int, int)> crosses = new HashSet<(int, int)>();
  HashSet<(int, int)> wires = new HashSet<(int, int)>();
  List<string> grid = new List<string>();
  for (int i = 0; i < 400; i++)
  {
    grid.Add("".PadLeft(400, '.'));
  }
  lines.ToList().ForEach(l =>
  {
    int y = 0, x = 0;
    var L = l.Split(',').ToList();
    Console.WriteLine(l);
    List<(int, int)> wire = new List<(int, int)>();
    L.ForEach(ll =>
    {
      
      // Console.WriteLine($"Crosses = {crosses.Count}");
      string D = ll[0].ToString();
      int direction = (int)(Direction)Enum.Parse(typeof(Direction), D);
      var (dx, dy) = directions[direction];
      int nb = int.Parse(ll.Substring(1));
      // Console.WriteLine($"D {D} dy {dy} dx {dx} nb {nb}");
      for (int i = 0; i < nb; i++)
      {
        y += dy;
        x += dx;
        // Console.WriteLine($"{y} {x}");
        if (!wire.Contains((x, y)))
        {
          if (wires.Contains((x, y)))
          {
            crosses.Add((x, y));
          }
          wires.Add((x, y));
        }
        wire.Add((x, y));
      };

    });
  });
  int m = 999999;
  crosses.ToList().ForEach(p =>
  {
    var (x, y) = p;
    int ay = Math.Abs(y);
    int ax = Math.Abs(x);
    Console.WriteLine($"{ax} {ay}");
    if (ax + ay < m) m = ax + ay;
  });
  Console.WriteLine($"{m}");
}

void part2()
{


}
part1();
part2();

enum Direction
{
  U,
  L,
  R,
  D
}
