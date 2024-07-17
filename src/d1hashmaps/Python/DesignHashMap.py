from Bucket import Bucket


class DesignHashMap:
    def __init__(self):
        self.key_space = 2069
        self.buckets = [Bucket() for _ in range(self.key_space)]

    def put(self, key, value):
        hash_key = key % self.key_space
        self.buckets[hash_key].update(key, value)

    def get(self, key):
        hash_key = key % self.key_space
        return self.buckets[hash_key].get(key)

    def remove(self, key):
        hash_key = key % self.key_space
        self.buckets[hash_key].remove(key)

    def print_hash_map(self):
        for i, bucket in enumerate(self.buckets):
            if bucket.pairs:
                pairs_str = ', '.join(
                    f'{{key: {pair.key}, value: {pair.value}}}' for pair in bucket.pairs)
                print(f'Bucket {i}: {pairs_str}')
