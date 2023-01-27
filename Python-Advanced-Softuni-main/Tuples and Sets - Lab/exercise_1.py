# Count Same Values

# Задаване на променливите:
_input = input().split(' ')
numbers = [float(v) for v in _input]
dictonary = dict()

# Решение:
for num in numbers:
    if num not in dictonary:
        dictonary[num] = 1
    else:
        dictonary[num] += 1

# Принтиране на резултата:
for num in dictonary:
    print(f"{num} - {dictonary[num]} times")
