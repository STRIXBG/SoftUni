# Capitals

# Въвеждам променливите:
li_1 = input().split(', ')
li_2 = input().split(', ')

packed = zip(li_1, li_2)
length = len(li_1)

# Решение на задачата:
for country, capital in packed:
    print(f"{country} -> {capital}")
