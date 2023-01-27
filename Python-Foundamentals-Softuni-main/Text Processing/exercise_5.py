# Emoticon Finder

# Задаване на променливите:
text = input().split(' ')

# Решение:
for word in text:
    if word[0] == ':':
        print(f"{word[0]}{word[1]}")
