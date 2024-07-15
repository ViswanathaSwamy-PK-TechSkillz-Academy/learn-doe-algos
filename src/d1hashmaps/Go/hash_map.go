package main

const KeySpace = 2069 // Define the size of the key space for hashing

// DesignHashMap represents a hash map.
type DesignHashMap struct {
	buckets []*Bucket // Slice of pointers to Buckets
}

// Constructor initializes the hash map.
func Constructor() DesignHashMap {
	hashMap := DesignHashMap{
		buckets: make([]*Bucket, KeySpace),
	}
	for i := range hashMap.buckets {
		hashMap.buckets[i] = NewBucket()
	}
	return hashMap
}

// Put inserts a key-value pair into the hash map or updates the value if the key already exists.
func (hm *DesignHashMap) Put(key int, value int) {
	hashKey := key % KeySpace
	hm.buckets[hashKey].Update(key, value)
}

// Get returns the value associated with the key if it exists, otherwise returns -1.
func (hm *DesignHashMap) Get(key int) int {
	hashKey := key % KeySpace
	return hm.buckets[hashKey].Get(key)
}

// Remove deletes the key-value pair from the hash map if it exists.
func (hm *DesignHashMap) Remove(key int) {
	hashKey := key % KeySpace
	hm.buckets[hashKey].Remove(key)
}
