int[] program = File.ReadAllText(@"C:\Users\yvesg\git\aoc2019\02\data.txt").Split(',').Select(p => int.Parse(p)).ToArray();

void part1()
{
  int step = 0;
  program[1] = 12;
  program[2] = 2;
  while (true)
  {
    if (program[step] == 99) break;
    int op = program[step];
    int op1 = program[program[step + 1]];
    int op2 = program[program[step + 2]];
    if (op == 1) { program[program[step + 3]] = op1 + op2; }
    else { program[program[step + 3]] = op1 * op2; }
    step += 4;
  }
  Console.WriteLine(program[0]);
}

void part2()
{
  int step = 0;
  bool cont = true;
  int noun = 0;
  int verb = 0;
  while (cont && noun <= 99)
  {
    verb = 0;
    while (cont && verb <= 99)
    {
      step = 0;
      program = File.ReadAllText(@"C:\Users\yvesg\git\aoc2019\02\data.txt").Split(',').Select(p => int.Parse(p)).ToArray();
      program[1] = noun;
      program[2] = verb;
      while (true)
      {
        int op = program[step];
        if (op == 99) break;
        int op1 = program[program[step + 1]];
        int op2 = program[program[step + 2]];
        int dest = program[step + 3];
        if (op == 1)
        {
          program[dest] = op1 + op2;
        }
        else
        {
          program[dest] = op1 * op2;
        }
        step += 4;
      }
      cont = program[0] != 19690720;
      if (cont) verb++;
    }
    if (cont) noun++;
  }

  Console.WriteLine($"noun {noun} verb {verb}");
}

part1();
part2();