# Unique Usernames

# Създаване на променливите
usernames = list()
query_num = int(input())

# Цикъл за решаване на задачата
for i in range(query_num):
    _input = input()
    if _input not in usernames:
        print(_input)
    usernames.append(_input)
