# Repeat Strings

# Задаване на променливите:
strings = input().split(" ")
result = str()

# Решение:
for word in strings:
    length = len(word)
    result += word * length

# Извеждане на резултата:
print(result)
