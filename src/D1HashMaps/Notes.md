#Explanation

> 1. Pair Structure: A simple structure to store key-value pairs.
> 1. Bucket Structure: Uses a slice to store multiple pairs to handle hash collisions via chaining. Contains methods to Get, Update, and Remove pairs.
> 1. DesignHashMap Structure: Contains an array of Bucket pointers, initialized with the specified key space size. The hash function simply takes the modulus of the key with the key space size.
> 1. Constructor: Initializes the DesignHashMap with an empty bucket for each slot.
> 1. Put Method: Computes the hash key, then calls the Update method on the corresponding bucket to insert or update the key-value pair.
> 1. Get Method: Computes the hash key, then retrieves the value from the corresponding bucket.
> 1. Remove Method: Computes the hash key, then removes the key-value pair from the corresponding bucket.
