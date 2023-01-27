# Profile
# Незавършена

# Създаване на клас:
class Profile:
    def __init__(self, username, password):
        self.username = username
        self.password = password

    def __str__(self):
        return f'You have a profile with username: "{self.username}" and password: {"*"*len(self.password)}.'


# Извеждане на резултат:

profile_with_invalid_password = Profile('My_username', 'My-password')
print(profile_with_invalid_password)

profile_with_invalid_username = Profile('Too_long_username', 'Any')
print(profile_with_invalid_username)

correct_profile = Profile("Username", "Passw0rd")
print(correct_profile)
