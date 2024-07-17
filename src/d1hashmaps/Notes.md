# Explanation

> 1. Pair Structure: A simple structure to store key-value pairs.
> 1. Bucket Structure: Uses a slice to store multiple pairs to handle hash collisions via chaining. Contains methods to Get, Update, and Remove pairs.
> 1. DesignHashMap Structure: Contains an array of Bucket pointers, initialized with the specified key space size. The hash function simply takes the modulus of the key with the key space size.
> 1. Constructor: Initializes the DesignHashMap with an empty bucket for each slot.
> 1. Put Method: Computes the hash key, then calls the Update method on the corresponding bucket to insert or update the key-value pair.
> 1. Get Method: Computes the hash key, then retrieves the value from the corresponding bucket.
> 1. Remove Method: Computes the hash key, then removes the key-value pair from the corresponding bucket.

## Few Commands

```powershell
javac *.java && java Main
```

## Additional Notes

In JavaScript, there are two main module systems: CommonJS and ES6 modules (ESM). The choice between `export default` and `module.exports` depends on which module system you're using.

### CommonJS (used in Node.js)

In CommonJS, you use `module.exports` to export modules and `require` to import them. This is commonly used in Node.js.

**Pair.js**

```javascript
class Pair {
  constructor(key, value) {
    this.key = key;
    this.value = value;
  }
}

module.exports = Pair;
```

**Bucket.js**

```javascript
const Pair = require("./Pair");

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
    this.pairs = this.pairs.filter((pair) => pair.key !== key);
  }
}

module.exports = Bucket;
```

**DesignHashMap.js**

```javascript
const Bucket = require("./Bucket");

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
        const pairs = bucket.pairs
          .map((pair) => `{key: ${pair.key}, value: ${pair.value}}`)
          .join(" ");
        console.log(`Bucket ${i}: ${pairs}`);
      }
    });
  }
}

module.exports = DesignHashMap;
```

**main.js**

```javascript
const DesignHashMap = require("./DesignHashMap");

const main = () => {
  const hashMap = new DesignHashMap();
  const keys = [5, 2069, 2070, 2073, 4138, 2068];
  const values = [100, 200, 400, 500, 1000, 5000];
  const operations = [
    "Get",
    "Get",
    "Put",
    "Get",
    "Put",
    "Get",
    "Get",
    "Remove",
    "Get",
    "Get",
    "Remove",
    "Get",
  ];
  const operationKeys = [
    [5],
    [2073],
    [2073, 250],
    [2073],
    [121, 110],
    [121],
    [2068],
    [2069],
    [2069],
    [2071],
    [2071],
    [2071],
  ];

  // Initialize the hash map with initial keys and values
  keys.forEach((key, i) => {
    hashMap.put(key, values[i]);
  });

  // Execute the operations
  operations.forEach((op, i) => {
    switch (op) {
      case "Put":
        console.log(
          `${i + 1}.\tPut(${operationKeys[i][0]}, ${operationKeys[i][1]})`
        );
        hashMap.put(operationKeys[i][0], operationKeys[i][1]);
        break;
      case "Get":
        console.log(`${i + 1}.\tGet(${operationKeys[i][0]})`);
        console.log(`\tValue returned: ${hashMap.get(operationKeys[i][0])}`);
        break;
      case "Remove":
        console.log(`${i + 1}.\tRemove(${operationKeys[i][0]})`);
        hashMap.remove(operationKeys[i][0]);
        break;
    }

    // Print the current state of the hash map
    console.log("\nCurrent Hash Map:");
    hashMap.printHashMap();
    console.log("-".repeat(100));
  });
};

main();
```

### ES6 Modules (ESM)

In ES6 modules, you use `export` and `import`. This is the modern standard and is used in both browser environments and Node.js (with specific configurations).

**Pair.js**

```javascript
class Pair {
  constructor(key, value) {
    this.key = key;
    this.value = value;
  }
}

export default Pair;
```

**Bucket.js**

```javascript
import Pair from "./Pair.js";

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
    this.pairs = this.pairs.filter((pair) => pair.key !== key);
  }
}

export default Bucket;
```

**DesignHashMap.js**

```javascript
import Bucket from "./Bucket.js";

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
        const pairs = bucket.pairs
          .map((pair) => `{key: ${pair.key}, value: ${pair.value}}`)
          .join(" ");
        console.log(`Bucket ${i}: ${pairs}`);
      }
    });
  }
}

export default DesignHashMap;
```

**main.js**

```javascript
import DesignHashMap from "./DesignHashMap.js";

const main = () => {
  const hashMap = new DesignHashMap();
  const keys = [5, 2069, 2070, 2073, 4138, 2068];
  const values = [100, 200, 400, 500, 1000, 5000];
  const operations = [
    "Get",
    "Get",
    "Put",
    "Get",
    "Put",
    "Get",
    "Get",
    "Remove",
    "Get",
    "Get",
    "Remove",
    "Get",
  ];
  const operationKeys = [
    [5],
    [2073],
    [2073, 250],
    [2073],
    [121, 110],
    [121],
    [2068],
    [2069],
    [2069],
    [2071],
    [2071],
    [2071],
  ];

  // Initialize the hash map with initial keys and values
  keys.forEach((key, i) => {
    hashMap.put(key, values[i]);
  });

  // Execute the operations
  operations.forEach((op, i) => {
    switch (op) {
      case "Put":
        console.log(
          `${i + 1}.\tPut(${operationKeys[i][0]}, ${operationKeys[i][1]})`
        );
        hashMap.put(operationKeys[i][0], operationKeys[i][1]);
        break;
      case "Get":
        console.log(`${i + 1}.\tGet(${operationKeys[i][0]})`);
        console.log(`\tValue returned: ${hashMap.get(operationKeys[i][0])}`);
        break;
      case "Remove":
        console.log(`${i + 1}.\tRemove(${operationKeys[i][0]})`);
        hashMap.remove(operationKeys[i][0]);
        break;
    }

    // Print the current state of the hash map
    console.log("\nCurrent Hash Map:");
    hashMap.printHashMap();
    console.log("-".repeat(100));
  });
};

main();
```

### Summary

- Use `module.exports` and `require` if you are using CommonJS (Node.js).
- Use `export` and `import` if you are using ES6 modules (modern JavaScript, supported by most browsers and Node.js with the appropriate configuration).

For a new project, ES6 modules are generally recommended due to their modern syntax and better support across different environments.
