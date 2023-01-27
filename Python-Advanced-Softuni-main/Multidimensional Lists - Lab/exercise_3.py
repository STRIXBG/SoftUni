# Flattering Matrix

# Задаване на променливите:
matrix = []
_input = input().split(', ')
rows = int(_input[0])

# Решение:
for i in range(rows):
    column = [int(x) for x in input().split(', ')]
    for element in column:
        matrix.append(element)

# Принтиране на резултата:
print(matrix)
