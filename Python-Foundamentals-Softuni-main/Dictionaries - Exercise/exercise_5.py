# Phonebook
phone_dictonary = dict()
count_names = int()

# Въвеждам променливите:
while True:
    _input = input()
    if _input.isdigit():
        count_names = int(_input)
        break
    else:
        li = _input.split('-')
        man_name = li[0]
        phone_num = li[1]
        phone_dictonary[man_name] = phone_num

for i in range(count_names):
    name_call = input()
    if name_call in phone_dictonary:
        for num in phone_dictonary:
            print(f"{num} -> {phone_dictonary[num]}")
    else:
        print(f"Contact {name_call} does not exist.")
