# List Basics

# Задаване на променливите:
numbers_list = input().split(' ')
opposite_numbers_list = list()

# Решение:
for num in numbers_list:
    number = int(num)
    number /= -1
    opposite_numbers_list.append(int(number))

# Извеждане на резултата:
print(opposite_numbers_list)
