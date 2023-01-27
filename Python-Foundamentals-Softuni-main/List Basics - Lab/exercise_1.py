# Strange Zoo

# Задаване на променливите:
tail = input()
body = input()
head = input()

# Решение:
meerkat = [tail, body, head]
meerkat[0], meerkat[2] = meerkat[2], meerkat[0]

# Принтиране на резултата:
print(meerkat)
