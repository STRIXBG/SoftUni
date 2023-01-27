# Glass
# Не е тестван

# Решение:
class Glass:
    content = 0
    capacity = 250

    def fill(self, ml):
        if ml+self.content > self.capacity:
            return f'Cannot add {ml} ml'
        else:
            self.content += self.capacity
            return f'Glass filled with {ml} ml'

    def empty(self):
        self.content = 0
        return 'Glass is now empty'

    def info(self):
        space_left = self.content - self.capacity
        return f'{space_left} ml left'


# Принтиране на резултата:
glass = Glass()
print(glass.fill(100))
print(glass.fill(200))
print(glass.empty())
print(glass.fill(200))
print(glass.info())
