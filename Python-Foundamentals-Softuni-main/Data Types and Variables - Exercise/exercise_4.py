# Sum of Chars

# Задаване на променливите:
lines = int(input())
result = int()

# Решение:
for i in range(lines):
    ch = input()
    ch_ascii = ord(ch)
    result += ch_ascii

# Принтиране:
print(f"The sum equals: {result}")
