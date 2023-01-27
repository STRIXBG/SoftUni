# Sum the Matrix Elements

# Задаване на променливите:
matrix = []
_input = input().split(', ')
rows = int(_input[0])
columns = int(_input[1])

# Решение:
for i in range(rows):
    column = [int(x) for x in input().split(', ')]
    matrix.append(column)

# Принтиране на резултата:
print(matrix)
