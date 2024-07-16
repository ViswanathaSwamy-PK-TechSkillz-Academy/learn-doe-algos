from DesignHashMap import DesignHashMap


def main():
    hash_map = DesignHashMap()
    keys = [5, 2069, 2070, 2073, 4138, 2068]
    values = [100, 200, 400, 500, 1000, 5000]
    operations = ["Get", "Get", "Put", "Get", "Put", "Get",
                  "Get", "Remove", "Get", "Get", "Remove", "Get"]
    operation_keys = [
        [5], [2073], [2073, 250], [2073],
        [121, 110], [121], [2068], [2069], [2069],
        [2071], [2071], [2071]
    ]

    # Initialize the hash map with initial keys and values
    for key, value in zip(keys, values):
        hash_map.put(key, value)

    # Execute the operations
    for i, op in enumerate(operations):
        if op == "Put":
            print(
                f"{i + 1}.\tPut({operation_keys[i][0]}, {operation_keys[i][1]})")
            hash_map.put(operation_keys[i][0], operation_keys[i][1])
        elif op == "Get":
            print(f"{i + 1}.\tGet({operation_keys[i][0]})")
            print(f"\tValue returned: {hash_map.get(operation_keys[i][0])}")
        elif op == "Remove":
            print(f"{i + 1}.\tRemove({operation_keys[i][0]})")
            hash_map.remove(operation_keys[i][0])

        # Print the current state of the hash map
        print("\nCurrent Hash Map:")
        hash_map.print_hash_map()
        print('-' * 100)


if __name__ == "__main__":
    main()
