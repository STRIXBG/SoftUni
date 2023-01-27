#Fast Food

#Задавам първите променливи
quanity = int(input())
sequence = input()
sequence_food = [int(x) for x in sequence.split(' ')]
sequence_not_served_food = list()

#Някои сметки
all_puruchased_food = int()

for food in sequence_food:
    all_puruchased_food += food
    if all_puruchased_food >= quanity:
        sequence_not_served_food.append(str(food))

#Извеждам резултата (Output)
print(max(sequence_food))

if quanity >= all_puruchased_food:
    print("Orders complete")
else:
    print('Orders left:',' '.join(sequence_not_served_food))
