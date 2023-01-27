# Print Part of the ASCII Table

# Задаване на променливите:
first_ch = int(input())
last_ch = int(input())
result = str()

# Решение:
for ascii_ch in range(first_ch, last_ch+1):
    result += chr(ascii_ch)
    result += ' '

# Извеждане на резултата:
print(result)
