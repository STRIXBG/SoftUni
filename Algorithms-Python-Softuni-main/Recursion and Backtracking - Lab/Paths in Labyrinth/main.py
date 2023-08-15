def is_exit(lab_pos):
    if lab_pos == 'e':
        return True
    return False

def is_wall(lab_pos):
    if lab_pos == '*':
        return True
    return False

def is_visited(lab_pos):
    if lab_pos == 'v':
        return True
    return False

def is_inbound(row, col, lab):
    if row < 0 or col < 0 or row >= len(lab) or col >= len(lab[0]):
        return False
    return True


def find_all_paths(row, col, lab, direction, path):
    if not is_inbound(row, col, lab):
        return
    
    current_row_col = lab[row][col]
    #print(f'{row} {col}')

    if is_wall(current_row_col):
        return
    
    if is_visited(current_row_col):
        return
    
    path.append(direction)
    if is_exit(current_row_col):
        print(''.join(path))
        path.pop()
        return

    lab[row][col] = 'v'

    find_all_paths(row, col + 1, lab, 'R', path)
    find_all_paths(row, col - 1, lab, 'L', path)
    find_all_paths(row + 1, col, lab, 'D', path)
    find_all_paths(row - 1, col, lab, 'U', path)

    lab[row][col] = '-'

    path.pop()

lab = []
rows = int(input())
cols = int(input())

for _ in range(rows):
    lab.append(list(input()))

find_all_paths(0, 0, lab, '', [])
