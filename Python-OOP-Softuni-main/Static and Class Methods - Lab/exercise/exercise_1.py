# Calculator

# Създаване на клас:
class Calculator:

    @staticmethod
    def add(*args):
        result = int()
        for x in args:
            result += x
        return result

    @staticmethod
    def multiply(*args):
        result = 1
        for x in args:
            result *= x
        return result

    @staticmethod
    def divide(*args):
        result = 1
        for x in args:
            result /= x
        return result

    @staticmethod
    def subtract(*args):
        result = int()
        for x in args:
            result -= x
        return result


# Извеждане на резултат:
calculator = Calculator
print(calculator.add(1, 2, 3))
print(calculator.multiply(1, 2, 3))
print(calculator.divide(1, 2))
print(calculator.subtract(1, 2))
