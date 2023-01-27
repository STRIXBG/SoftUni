# Parking Lot

# Задаване на променливите:
n = int(input())
parking_lot = set()

# Решение:
for i in range(n):
    _input = input().split(', ')
    direction = _input[0]
    car_num = _input[1]
    if direction == 'IN':
        parking_lot.add(car_num)
    if direction == 'OUT':
        if car_num in parking_lot:
            parking_lot.remove(car_num)

# Принтиране на резултата:
if len(parking_lot) == 0:
    print("Parking Lot is Empty")
else:
    for car_num in parking_lot:
        print(car_num)
