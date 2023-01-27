# Odd and Even Sum

# Функция:
def sum_odds_and_evens(num):
    odds_sum = 0
    evens_sum = 0
    str_num = str(num)
    for char in str_num:
        if int(char) % 2 == 0:
            evens_sum += int(char)
        else:
            odds_sum += int(char)
    print(f"Odd sum = {odds_sum}, Even sum = {evens_sum}")


# Променливите:
number = int(input())

# Извеждане на резултата:
sum_odds_and_evens(number)
