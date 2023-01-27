# Periodic Table

# Задавам променливите:
unique_elements = set()
query_count = int(input())

# Цикъл за решаване на задачата:
for i in range(query_count):
    _input = input()
    sequence = [x for x in _input.split(' ')]
    for element in sequence:
        unique_elements.add(element)

# Принтиране на резултата, чрез цикъл:
for element in unique_elements:
    print(element)
