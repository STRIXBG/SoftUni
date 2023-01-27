# Multiplication Function

# Задаване на променливите:
quanity = input()


# Решение:
def multiply(quan):
    quan = quan.split(', ')
    result = 1
    for number in quan:
        result *= int(number)
    return result


# Принтиране на резултата:
print(multiply(quanity))
