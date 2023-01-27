# Password Validator

# Функция:
def check_for_symbols(passw):
    for item in passw:
        asci = ord(item)
        if asci < 48 & asci > 90:
            return True
    return False


def count_digits(passw):
    digits = 0
    for item in passw:
        asci = ord(item)
        if asci >= 48 and asci <= 57:
            digits += 1
    return digits


def check_password(passw):
    valid = True
    pass_len = len(passw)
    pass_digits = count_digits(passw)
    pass_contains_symbols = check_for_symbols(passw)
    if pass_len < 6 or pass_len > 10:
        valid = False
        print('Passowrd must be between 6 and 10 characters')
    if pass_digits < 2:
        valid = False
        print('Password must have at least 2 digits')
    if pass_contains_symbols is True:
        valid = False
        print('Password must consist only of letters and digits')
    if valid is True:
        print('Password is valid')


# Променливите:
password = input()

# Извеждане на резултата:
check_password(password)
