using System.Security.AccessControl;

string[] lines = File.ReadAllLines(@"C:\Users\yvesg\git\aoc2019\03\test.txt");

void part1()
  {
    
    List<Dir[]> wires = new List<Dir[]>();
    lines.ToList().ForEach(l => {
      Dir[] dirs = [];
      var L = l.Split(',').ToList();
      L.ForEach(x => {Console.WriteLine(x);});

    });
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

  

  