# Character Multiplier

# Задаване на променливите:
strings = input().split(' ')
total_sum = int()
biggest_string_index = -1
first_str = strings[0]
second_str = strings[1]

# Решение:
if len(first_str) > len(second_str):
    biggest_string_index = 0
else:
    biggest_string_index = 1

if biggest_string_index == 0:
    for i in range(len(first_str)):
        if len(second_str) > i:
            total_sum += ord(first_str[i]) * ord(second_str[i])
        else:
            total_sum += ord(first_str[i])
elif biggest_string_index == 1:
    for i in range(len(second_str)):
        if len(first_str) > i:
            total_sum += ord(first_str[i]) * ord(second_str[i])
        else:
            total_sum += ord(second_str[i])

print(total_sum)


