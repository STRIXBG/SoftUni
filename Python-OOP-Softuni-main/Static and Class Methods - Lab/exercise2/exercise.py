# Shop
# Недовършен

# Създаване на клас:
class Shop:
    items = dict()

    # Инициализация:
    def __init__(self, name, stype, capacity):
        self.name = name
        self.type = stype
        self.capacity = capacity

    # Методи:
    def small_shop(self, name, stype):
        self.capacity = 10
        self.name = name
        self.type = stype

    def add_item(self, item_name):
        if self.capacity >= 1:
            self.capacity -= 1
            self.items[item_name] += 1
            return f"{item_name} added to the shop"
        elif self.capacity == 0:
            return "Not enough capacity in the shop"

    def remove_item(self, item_name, amount):
        if item_name not in self.items:
            return f"Cannot remove {amount} {item_name}"
        if item_name in self.items:
            if self.items[item_name] >= amount:
                return f"{amount} {item_name} removed from the shop"
            elif self.items[item_name] < amount:
                return f"Cannot remove {amount} {item_name}"

    def __repr__(self):
        rep = f"{self.name} of type {self.type} with capacity {self.capacity}"
        return rep


# Извеждане на резултат:

fresh_shop = Shop("Fresh Shop", "Fruit and Veg", 50)
small_shop = Shop.small_shop("Fashion Boutique", "Clothes")
print(fresh_shop)
print(small_shop)
