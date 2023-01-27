def calc_sum(numbers, index):
    if index == len(numbers) - 1:
        return numbers[index]
    return numbers[index] + calc_sum(numbers, index+1)

if __name__ == '__main__':
    _input = input()
    li = [int(x) for x in _input.split(' ')]
    print(calc_sum(li, 0))
