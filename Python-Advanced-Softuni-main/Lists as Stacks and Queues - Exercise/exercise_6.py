# Balanced Parentheses

#Задаване на променливи:
sequence = input()


#Функции:
def Compare(opening, closing):
    if opening == '(' and closing == ')':
        return True
    if opening == '[' and closing == ']':
        return True
    if opening == '{' and closing == '}':
        return True
    return False

def BalancedBrackets(Str):
    stack = list()
    for element in Str:
        if element == '[' or element =='{' or element == '(':
            stack.append(element)
        elif element == ']' or element == '}' or element == ')':
            if len(stack) > 0:
                top_element = stack.pop()
                #print(f'Top Element: {top_element}, Element: {element}')
                if Compare(top_element, element) == False:
                    return False
            elif len(stack) == 0:
                return False
    return True


#Задаване на входни данни:
if BalancedBrackets(sequence) == True:
    print('YES')
elif BalancedBrackets(sequence) == False:
    print('NO')
