# Rounding

# Задаване на променливите:
_input = input().split(' ')
numbers = [float(i) for i in _input]


# Решение:
def calculate(nums_li):
    result = [round(n) for n in nums_li]
    return result


# Принтиране на резултата:
print(calculate(numbers))
