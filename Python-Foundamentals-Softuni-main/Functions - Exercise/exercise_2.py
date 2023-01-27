# Add to Subtract

# Функция:
def sum_numbers(num1, num2):
    result = num1 + num2
    return result


def subtract(returned_result, num3):
    result = returned_result - num3
    return result


# Променливите:
number1 = int(input())
number2 = int(input())
number3 = int(input())

# Извеждане на резултата
returned_num = sum_numbers(number1, number2)
print(subtract(returned_num, number3))
