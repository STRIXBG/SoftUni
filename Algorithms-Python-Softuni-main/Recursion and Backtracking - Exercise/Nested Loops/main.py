def simulate_nested_loops(level, max_level, variables):
    if level > max_level:
        print(*variables)
    else:
        for i in range(1, max_level + 1):
            variables[level - 1] = i
            simulate_nested_loops(level + 1, max_level, variables)

n = int(input())
variables = [0] * n
simulate_nested_loops(1, n, variables)
