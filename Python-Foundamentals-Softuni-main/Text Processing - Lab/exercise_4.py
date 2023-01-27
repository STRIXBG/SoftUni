# Text Filter

# Задаване на променливите:
banned_words = input().split(', ')
text = input()

# Решение:
for word in banned_words:
    while word in text:
        text = text.replace(word, "*" * len(word))

# Извеждане на резултата:
print(text)
