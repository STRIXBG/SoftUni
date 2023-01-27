# Absolute Values

# Задаване на променливите:
_input = input().split(' ')
numbers = [float(i) for i in _input]

# Решение:
for i in range(len(numbers)):
    numbers[i] = abs(numbers[i])

# Принтиране на резултата:
print(numbers)
