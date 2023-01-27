# Multiples List

# Задаване на променливите:
factor = int(input())
count = int(input())
li = list() # length: count

# Решение:
for i in range(1, count+1):
    num = i*factor
    li.append(num)

# Извеждане на резултата:
print(li)
