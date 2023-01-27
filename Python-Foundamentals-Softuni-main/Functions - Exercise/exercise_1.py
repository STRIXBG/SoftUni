# Smallest of Three Numbers

# Функция:
def find_smallest_num(num1, num2, num3):
    smallest_num = num1
    if num2 < smallest_num:
        smallest_num = num2
    if num3 < smallest_num:
        smallest_num = num3
    return smallest_num


# Променливите:
n1 = int(input())
n2 = int(input())
n3 = int(input())

# Извеждане на резултата
print(find_smallest_num(n1, n2, n3))
