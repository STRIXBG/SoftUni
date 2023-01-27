# Digits, Letters and Others

# Задаване на променливите:
text = input()
digits = str()
letters = str()
other = str()

# Решение:
for ch in text:
    if ch.isdigit():
        digits += ch
    elif ch.isalpha():
        letters += ch
    else:
        other += ch

# Извеждане на резултата:
print(digits)
print(letters)
print(other)
