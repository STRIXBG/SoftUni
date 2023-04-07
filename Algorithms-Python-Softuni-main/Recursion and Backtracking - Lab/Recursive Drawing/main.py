start_len = None


def print_fig(length, figure):
    construction = ""
    for i in range(0, length):
        construction += figure
    print(construction)


def draw(length, figure):
    if figure == '*':
        if length > 0:
            print_fig(length, figure)
            return draw(length - 1, figure)
        else:
            return draw(1, '#')

    elif figure == '#':
        if length != start_len+1:
            print_fig(length, figure)
            return draw(length + 1, figure)
        else:
            return 1


if __name__ == '__main__':
    start_len = int(input())
    draw(start_len, '*')
