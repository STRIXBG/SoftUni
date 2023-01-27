
# Reverse Strings

# Задаване на променливите:
text = input()

# Решение:
while text != 'end':
    text_reversed = str()
    for ch in reversed(text):
        text_reversed += ch
    print(text + ' = ' + text_reversed)
    text = input()
