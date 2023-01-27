# Min Max and Sum

# Функция:
def get_int_sequence(seq):
    result = list()
    for element in seq:
        result.append(int(element))
    return result


def find_min_max_sum(seq):
    sum = int()
    max_n = max(seq)
    min_n = min(seq)
    for num in seq:
        sum += num
    print(f'The minimum number is: {min_n}')
    print(f'The maximum number is: {max_n}')
    print(f'The sum number is: {sum}')

# Променливите:
sequence = input().split(' ')
int_sequence = get_int_sequence(sequence)

# Извеждане на резултата:
find_min_max_sum(int_sequence)
