const Bucket = require('./Bucket');

class DesignHashMap {
    constructor() {
        this.keySpace = 2069;
        this.buckets = Array.from({ length: this.keySpace }, () => new Bucket());
    }

    put(key, value) {
        const hashKey = key % this.keySpace;
        this.buckets[hashKey].update(key, value);
    }

    get(key) {
        const hashKey = key % this.keySpace;
        return this.buckets[hashKey].get(key);
    }

    remove(key) {
        const hashKey = key % this.keySpace;
        this.buckets[hashKey].remove(key);
    }

    printHashMap() {
        this.buckets.forEach((bucket, i) => {
            if (bucket.pairs.length > 0) {
                const pairs = bucket.pairs.map(pair => `{key: ${pair.key}, value: ${pair.value}}`).join(' ');
                console.log(`Bucket ${i}: ${pairs}`);
            }
        });
    }
}

module.exports = DesignHashMap;
