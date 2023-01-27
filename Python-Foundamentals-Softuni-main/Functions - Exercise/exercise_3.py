# Characters in Range

# Функция:
def characters_in_range(first_char, last_char):
    first_ascii = ord(first_char)
    last_ascii = ord(last_char)
    result = str()
    for i in range(first_ascii+1, last_ascii):
        result += chr(i)
        result += ' '
    print(result)


# Променливите:
first_ch = input()
last_ch = input()

# Извеждане на резултата:
characters_in_range(first_ch, last_ch)
