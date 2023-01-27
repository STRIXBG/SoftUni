# Supermarket

# Задаване на променливите:
text = input()
quene = []

# Решение:
while True:
    if text == 'End':
        print(f"{len(quene)} people remaining.")
        break
    elif text == 'Paid':
        for name in quene:
            print(name)
        quene.clear()
    else:
        quene.append(text)
    text = input()
