# Extract File

# Задаване на променливите:
file_dir = input()
text = file_dir.split('\\')

# Решение:
file_name = text[-1].split('.')[0]
print(f"File name: {file_name}")
file_extension = text[-1].split('.')[1]
print(f"File extension: {file_extension}")
