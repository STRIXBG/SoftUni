SIZE = 8

def print_solution(board):
    for row in range(SIZE):
        for col in range(SIZE):
            print(board[row][col], end=' ')
        print(' ')
    print(' ')

def is_safe(board, row, col):
    for i in range(SIZE):
        if board[row][i] == '*' or board[i][col] == '*':
            return False

    for i, j in zip(range(row, -1, -1), range(col, -1, -1)):
        if board[i][j] == '*':
            return False

    for i, j in zip(range(row, -1, -1), range(col, SIZE)):
        if board[i][j] == '*':
            return False
    
    return True

def is_inbound(row, col):
    if row >= 0 and col >= 0 and row < SIZE and col < SIZE:
        return True
    return False

def is_finished_sol(board):
    count = 0
    for row in range(SIZE):
        for col in range(SIZE):
            if board[row][col] == '*':
                count += 1
    if count == SIZE:
        return True
    return False

def solve_n_queens(board, attack_row):
    if is_finished_sol(board):
        print_solution(board)
        return
    
    if attack_row >= SIZE:
        return

    for col in range(SIZE):
        if is_safe(board, attack_row, col):
            board[attack_row][col] = '*'
            solve_n_queens(board, attack_row+1)
            board[attack_row][col] = '-'

board = [['-' for _ in range(SIZE)] for _ in range(SIZE)]
solve_n_queens(board, 0)
