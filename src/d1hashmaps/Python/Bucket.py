from Pair import Pair


class Bucket:
    def __init__(self):
        self.pairs = []

    def get(self, key):
        for pair in self.pairs:
            if pair.key == key:
                return pair.value
        return -1  # Return -1 if the key does not exist

    def update(self, key, value):
        for pair in self.pairs:
            if pair.key == key:
                pair.value = value
                return
        self.pairs.append(Pair(key, value))

    def remove(self, key):
        self.pairs = [pair for pair in self.pairs if pair.key != key]
