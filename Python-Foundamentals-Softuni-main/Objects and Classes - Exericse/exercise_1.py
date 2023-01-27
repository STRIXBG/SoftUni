# Storage

class Storage:
    storage = list()

    def __init__(self, capacity):
        self.capacity = capacity

    def add_product(self, product):
        if self.capacity > len(self.storage):
            self.storage.append(product)

    def get_products(self):
        print(self.storage)
