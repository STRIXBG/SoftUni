# Sets of Elements

# Задаване на променливите:
_input = input()
sequence = [x for x in _input.split(' ')]
len_N = sequence[0]
len_M = sequence[1]
array_N = set()
array_M = set()
array_N_M = set()
common_numbers = set()

# Цикъл за въвеждане на данни:
for i in range(int(len_N)):
    _input = int(input())
    array_N.add(_input)
    array_N_M.add(_input)

for i in range(int(len_M)):
    _input = int(input())
    array_M.add(_input)
    array_N_M.add(_input)

# Цикъл за решаване на задачата:
for number in array_N_M:
    if number in array_N and number in array_M:
        if number not in common_numbers:
            common_numbers.add(number)

# Извеждам резултата:
for number in common_numbers:
    print(number)
