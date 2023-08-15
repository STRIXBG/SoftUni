def reverse_array(numbers, idx):
    if idx < 0:
        return ""
    return str(numbers[idx]) + ' ' + str(reverse_array(numbers, idx-1))

user_input = input().split()
array = [int(number) for number in user_input]
length = len(array) - 1
reversed_array = reverse_array(array, length)
print(reversed_array)
