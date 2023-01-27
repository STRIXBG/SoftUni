# Substring

# Задаване на променливите:
first = input()
second = input()

# Решение:
while first in second:
    second = second.replace(first, "")

# Извеждане на резултата:
print(second)
