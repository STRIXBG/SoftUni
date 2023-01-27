# Elevator
import math

# Променливите:
number_of_people = int(input())
capacity_persons = int(input())

# Решение:
courses = math.ceil(number_of_people/capacity_persons)

# Извеждане на резултата:
print(courses)
