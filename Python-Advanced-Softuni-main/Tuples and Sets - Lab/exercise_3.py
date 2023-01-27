# Record Unique Names

# Задаване на променливите:
n = int(input())
names = set()

# Решение:
for i in range(n):
    name = input()
    names.add(name)

names = sorted(names)

# Принтиране на резултата:
for name in names:
    print(name)
