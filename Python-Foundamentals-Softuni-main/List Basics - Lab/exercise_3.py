# List Statistics

# Задаване на променливите:
n = int(input())
positives = list()
negatives = list()

# Решение:
for i in range(n):
    current_number = int(input())
    if current_number >= 0:
        positives.append(current_number)
    else:
        negatives.append(current_number)

# Принтиране на резултата:
print(positives)
print(negatives)
print(f"Count of positives: {len(positives)}. Sum of negatives: {sum(negatives)}")
