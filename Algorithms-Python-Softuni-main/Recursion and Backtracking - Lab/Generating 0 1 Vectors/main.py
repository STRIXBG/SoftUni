def generate_01(vector, idx):
    if idx >= len(vector):
        print(*vector, sep='')
        return
    
    for number in range(2):
        vector[idx] = number
        generate_01(vector, idx+1)


user_input = int(input())
vector = [0] * user_input
generate_01(vector, 0)
