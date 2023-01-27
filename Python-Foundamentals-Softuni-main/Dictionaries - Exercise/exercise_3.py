# Count Chars in a String

# Въвеждам променливите:
dictonary = {}
sequence_of_strs = set()
last_resource = str()
last_quanity = int()

# Получаване на входните данни:
index = 0
count = 0
while True:
    index += 1
    _input = input()
    if _input == 'stop':
        break
    if index % 2 == 0:
        last_quanity = _input
        if last_resource not in dictonary:
            dictonary[last_resource] = last_quanity
        else:
            current_value = dictonary[last_resource]
            new_value = int(current_value) + int(last_quanity)
            dictonary[last_resource] = new_value
    else:
        last_resource = _input

# Принтиране на резултата:
for item in dictonary:
    print(f"{item} -> {dictonary[item]}")
