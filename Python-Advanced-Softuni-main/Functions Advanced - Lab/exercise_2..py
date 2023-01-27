# Person Info

# Решение:
def get_info(**dic):
    name, town, age = dic.values()
    text = f"This is {name} from {town} and he is {age} years old"
    return text

# Резултат:
print(get_info(**{"name": "George", "town": "Sofia", "age": 20}))
