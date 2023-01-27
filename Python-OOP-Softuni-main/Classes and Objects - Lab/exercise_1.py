# Vehicle

# Решение:
class Vehicle:
    def __init__(self, mileage, max_speed=150, gadgets=None):
        if gadgets is None:
            gadgets = []
        self.max_speed = max_speed
        self.mileage = mileage
        self.gadgets = gadgets


# Принтиране на резултата:
car = Vehicle(20)
print(car.max_speed)
print(car.mileage)
print(car.gadgets)
car.gadgets.append('Hudly Wireless')
print(car.gadgets)
