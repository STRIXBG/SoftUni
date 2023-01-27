# Caesar Cipher

# Задаване на променливите:
text = input()
encrypted_text = str()

# Решение:
for letter in text:
    enc_letter_ascii = ord(letter) + 3
    enc_letter = chr(enc_letter_ascii)
    encrypted_text += enc_letter

# Принтиране на резултата:
print(encrypted_text)
