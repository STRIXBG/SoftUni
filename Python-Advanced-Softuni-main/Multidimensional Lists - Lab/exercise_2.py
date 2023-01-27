# Even Matrix

# Задаване на променливите:
matrix = []
_input = input().split(', ')
rows = int(_input[0])

# Решение:
for i in range(rows):
    column = [int(x) for x in input().split(', ') if int(x) % 2 == 0]
    matrix.append(column)
# Принтиране на резултата:
print(matrix)
