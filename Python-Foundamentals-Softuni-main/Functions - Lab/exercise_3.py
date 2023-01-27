# Calculations

# Задаване на променливите:
input_operator = input()
first_num = int(input())
second_num = int(input())


# Решение:
def solve(a, b, operator):
    result = None
    if operator == 'multiply':
        result = a * b
    elif operator == 'divide':
        result = a / b
    elif operator == 'add':
        result = a + b
    elif operator == 'subtract':
        result = a - b
    return result


# Принтиране на резултата:
print(solve(first_num, second_num, input_operator))
