# Emoticon Finder

# Задаване на променливите:
text = input()
last_letter = chr
new_text = str()

# Решение:
for letter in text:
    if last_letter != letter:
        new_text += letter
    last_letter = letter

# Принтиране на резултата:
print(new_text)
