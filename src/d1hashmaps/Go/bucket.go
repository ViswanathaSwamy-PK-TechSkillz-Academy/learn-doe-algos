package main

// Pair represents a key-value pair.
type Pair struct {
	key   int
	value int
}

// Bucket represents a bucket for storing key-value pairs.
type Bucket struct {
	bucket []Pair // Slice to store key-value pairs
}

// NewBucket creates a new instance of Bucket.
func NewBucket() *Bucket {
	return &Bucket{
		bucket: make([]Pair, 0), // Initialize the slice
	}
}

// Get returns the value associated with the key if it exists, otherwise returns -1.
func (b *Bucket) Get(hashKey int) int {
	for _, pair := range b.bucket {
		if pair.key == hashKey {
			return pair.value
		}
	}
	return -1
}

// Update inserts a key-value pair into the bucket, or updates the value if the key already exists.
func (b *Bucket) Update(hashKey int, value int) {
	for i, pair := range b.bucket {
		if pair.key == hashKey {
			b.bucket[i].value = value
			return
		}
	}
	b.bucket = append(b.bucket, Pair{key: hashKey, value: value})
}

// Remove deletes the key-value pair from the bucket if it exists.
func (b *Bucket) Remove(hashKey int) {
	for i, pair := range b.bucket {
		if pair.key == hashKey {
			b.bucket = append(b.bucket[:i], b.bucket[i+1:]...)
			return
		}
	}
}
