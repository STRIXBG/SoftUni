# Orders

# Задаване на променливите:
ord_name = input()
orders = int(input())


# Решение:
def calculate(order_name, num):
    price = None
    if order_name == 'coffee':
        price = 1.50
    elif order_name == 'water':
        price = 1.00
    elif order_name == 'coke':
        price = 1.40
    elif order_name == 'snacks':
        price = 2.00
    total_price = price * num
    return total_price


# Принтиране на резултата:
print(f"{calculate(ord_name, orders):0.2f}")
