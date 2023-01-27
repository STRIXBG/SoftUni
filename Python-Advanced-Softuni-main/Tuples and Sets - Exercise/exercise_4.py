# Count Symbols

# Задаване на променливите:
words_dictonary = {}
text = input()

# Решение:
for letter in text:
    if letter not in words_dictonary:
        words_dictonary[letter] = 1
    else:
        value = words_dictonary[letter]
        value = int(value) + 1
        words_dictonary[letter] = value

sort_orders = sorted(words_dictonary.items(), key=lambda x: x[0], reverse=False)

# Принтиране на резултата:
for i in sort_orders:
    print(f"{i[0]}: {i[1]} time/s")
