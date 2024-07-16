const Pair = require('./Pair');

class Bucket {
    constructor() {
        this.pairs = [];
    }

    get(key) {
        for (const pair of this.pairs) {
            if (pair.key === key) {
                return pair.value;
            }
        }
        return -1; // Return -1 if the key does not exist
    }

    update(key, value) {
        for (const pair of this.pairs) {
            if (pair.key === key) {
                pair.value = value;
                return;
            }
        }
        this.pairs.push(new Pair(key, value));
    }

    remove(key) {
        this.pairs = this.pairs.filter(pair => pair.key !== key);
    }
}

module.exports = Bucket;
