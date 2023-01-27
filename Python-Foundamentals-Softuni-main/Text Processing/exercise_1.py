# Valid Usernames

# Променливите:
usernames_li = input().split(', ')

# Решение:


def is_valid_symbol(lett):
    if ord(lett) >= ord('0') and ord(lett) <= ord('9'):
        return True
    if ord(lett) >= ord('A') and ord(lett) <= ord('Z'):
        return True
    if ord(lett) >= ord('a') and ord(lett) <= ord('z'):
        return True
    if ord(lett) == ord('_') or ord(lett) == ord('-'):
        return True
    return False


for username in usernames_li:
    to_print = True
    if len(username) < 3 or len(username) > 16:
        to_print = False
    for letter in username:
        if letter == ' ':
            to_print = False
        if not is_valid_symbol(letter):
            to_print = False
    if to_print is True:
        print(username)
