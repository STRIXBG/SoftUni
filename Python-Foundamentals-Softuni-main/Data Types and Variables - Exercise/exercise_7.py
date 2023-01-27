# Water Overflow

# Задаване на променливите:
lines = int(input())
capacity = 255
tank = 0

# Решение:
for i in range(lines):
    liters_of_water = int(input())
    if(tank + liters_of_water > capacity):
        print('Insufficient capacity!')
        if(i == lines-1):
            print(tank)
        continue
    tank += liters_of_water
    if (i == lines-1):
        print(tank)
