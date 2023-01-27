# Stacked Queries

# Задаване на променливите:
stack = list()
lines = int(input())

# Решение:
for i in range(lines):
    _input = input()
    query = _input.split(' ')
    if query[0] == '1':
        num = query[1]
        stack.append(num)
    elif query[0] == '2':
        stack.pop()
    elif query[0] == '3':
        max_num = max(stack)
        print(max_num)
    elif query[0] == '4':
        min_num = min(stack)
        print(min_num)

stack = stack[::-1]
print(', '.join(str(v) for v in stack))
