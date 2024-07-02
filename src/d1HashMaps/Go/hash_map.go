package main

const KeySpace = 1000 // Define the size of the key space for hashing

type DesignHashMap struct {
	data []*Bucket // Slice of pointers to Buckets
}

// Constructor initializes the hash map.
func Constructor() DesignHashMap {
	hashMap := DesignHashMap{
		data: make([]*Bucket, KeySpace),
	}
	for i := range hashMap.data {
		hashMap.data[i] = NewBucket()
	}
	return hashMap
}

// Put inserts a key-value pair into the hash map or updates the value if the key already exists.
func (this *DesignHashMap) Put(key int, value int) {
	hashKey := key % KeySpace
	this.data[hashKey].Update(key, value)
}

// Get returns the value associated with the key if it exists, otherwise returns -1.
func (this *DesignHashMap) Get(key int) int {
	hashKey := key % KeySpace
	return this.data[hashKey].Get(key)
}

// Remove deletes the key-value pair from the hash map if it exists.
func (this *DesignHashMap) Remove(key int) {
	hashKey := key % KeySpace
	this.data[hashKey].Remove(key)
}
