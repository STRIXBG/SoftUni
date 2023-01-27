# Matching Parentheses

# Задаване на променливите:
string = input()
stack = []

# Решение:
for i in range(len(string)):
    if string[i] == '(':
        stack.append(i)
    if string[i] == ')':
        popped = stack.pop()
        output = str()
        for j in range(popped, i+1):
            output += string[j]
        # Извеждане на резултат:
        print(output)
