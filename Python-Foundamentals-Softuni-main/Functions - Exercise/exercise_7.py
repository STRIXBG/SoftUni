# Palindrome Integers

# Функция:
def get_int_sequence(seq):
    result = list()
    for element in seq:
        result.append(int(element))
    return result


def get_backward_int(num):
    str_num = str(num)
    backward_num = str_num[::-1]
    backward_num = int(backward_num)
    return backward_num


def check_palindrome_ints(seq):
    for number in seq:
        number_backward = get_backward_int(number)
        if number == number_backward:
            print(True)
        else:
            print(False)


# Променливите:
sequence = input().split(', ')
int_sequence = get_int_sequence(sequence)

# Извеждане на резултата:
check_palindrome_ints(int_sequence)
