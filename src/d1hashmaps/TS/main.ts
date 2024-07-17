import { DesignHashMap } from './DesignHashMap';

const main = (): void => {
    const hashMap = new DesignHashMap();
    const keys = [5, 2069, 2070, 2073, 4138, 2068];
    const values = [100, 200, 400, 500, 1000, 5000];
    const operations = ["Get", "Get", "Put", "Get", "Put", "Get", "Get", "Remove", "Get", "Get", "Remove", "Get"];
    const operationKeys = [
        [5], [2073], [2073, 250], [2073],
        [121, 110], [121], [2068], [2069], [2069],
        [2071], [2071], [2071]
    ];

    // Initialize the hash map with initial keys and values
    keys.forEach((key, i) => {
        hashMap.put(key, values[i]);
    });

    // Execute the operations
    operations.forEach((op, i) => {
        switch (op) {
            case "Put":
                console.log(`${i + 1}.\tPut(${operationKeys[i][0]}, ${operationKeys[i][1]})`);
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
        console.log('-'.repeat(100));
    });
};

main();
