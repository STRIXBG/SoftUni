# Count Chars in a String

# Въвеждам променливите:
li = input().split(' ')
dictonary = {}

# Решение на задачата:
for word in li:
    for element in word:
        if element in dictonary:
            dictonary[element] += 1
        else:
            dictonary[element] = 1

# Принтиране на резултата:
for item in dictonary:
    print(f"{item} -> {dictonary[item]}")
