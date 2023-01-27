# Diagonals


# Задаване на променливите:
matrix = list()
n = int(input())
number_to_append = 0

# Инициализиране на матрицата:
for i in range(n):
    matrix_row = []
    for j in range(n):
        number_to_append += 1
        matrix_row.append(number_to_append)
    matrix.append(matrix_row)

# Резултат на Primary Diagonal:
primary_diag = []
number_of_item = 0
next_num_item = 0

for row in matrix:
    for item in row:
        if number_of_item == next_num_item:
            primary_diag.append(item)
            next_num_item += n+1
        number_of_item += 1

print(f"primary_diag: {primary_diag}")

# Резултат на Secondary Diagonal:
second_diag = []
number_of_item = n
next_num_item = n

for row in matrix[::-1]:
    for item in row:
        if number_of_item == next_num_item:
            second_diag.append(item)
            next_num_item -= n+1
        number_of_item -= 1

second_diag = second_diag[::-1]
print(f"Secondary diagonal: {primary_diag}. Sum: {sum(primary_diag)}")
print(f"Secondary diagonal: {second_diag}. Sum: {sum(second_diag)}")

# 1, 2, 3
# 4, 5, 6
# 7, 8, 9

# 0, 1, 2
# 3, 4, 5
# 6, 7, 8
