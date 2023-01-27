# Sort

# Функция:
def print_sequence(seq):
    result = list()
    for char in seq:
        result.append(int(char))
    result = sorted(result)
    print(result)


# Променливите:
sequence = input().split(' ')

# Извеждане на резултата:
print_sequence(sequence)
