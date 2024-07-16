package main

// Bucket represents a bucket for storing key-value pairs.
type Bucket struct {
	pairs []Pair // Slice to store key-value pairs
}

// NewBucket creates a new instance of Bucket.
func NewBucket() *Bucket {
	return &Bucket{
		pairs: make([]Pair, 0), // Initialize the slice
	}
}

// Get returns the value associated with the key if it exists, otherwise returns -1.
func (b *Bucket) Get(key int) int {
	for _, pair := range b.pairs {
		if pair.key == key {
			return pair.value
		}
	}
	return -1
}

// Update inserts a key-value pair into the bucket, or updates the value if the key already exists.
func (b *Bucket) Update(key int, value int) {
	for i, pair := range b.pairs {
		if pair.key == key {
			b.pairs[i].value = value
			return
		}
	}
	b.pairs = append(b.pairs, Pair{key: key, value: value})
}

// Remove deletes the key-value pair from the bucket if it exists.
func (b *Bucket) Remove(key int) {
	for i, pair := range b.pairs {
		if pair.key == key {
			b.pairs = append(b.pairs[:i], b.pairs[i+1:]...)
			return
		}
	}
}
