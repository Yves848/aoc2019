data = open("data.txt","r")

line = data.readline().replace('\n','')

verb = 0
noun = 0

cont = True

while (noun <= 99 and cont):
  verb = 0
  while (verb <=99 and cont):
    i = 0
    ar2 = list(map(int,line.split(',')))
    ar2[2] = verb
    ar2[1] = noun
    # print(f'ar2 {ar2}'  )
    opcode = ar2[i]

    while (opcode != 99):
      # print(f'i : {i}')
      # print(f'op : {ar[i]} - 2 = {ar[i+1]} - 3 : {ar[i+2]} - dest : {ar[i+3]}')
      op1 = ar2[ar2[i+1]]
      op2 = ar2[ar2[i+2]]
      dest = ar2[i+3]
      # print(f'opcode : {opcode} - op1 = {op1} - op2 : {op2} - dest : {dest}')
      match opcode:
        case 1:
          ar2[dest] = op1 + op2
        case 2:
          ar2[dest] = op1 * op2
      i+=4
      opcode = ar2[i]

    if ar2[0] == 19690720:
      cont = False

    if cont:
      verb += 1

  if cont:
    noun += 1

data.close()

print(f'verb {verb} noun {noun}')
print(f'total : {100*noun+verb}')