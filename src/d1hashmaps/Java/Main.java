public class Main {
    public static void main(String[] args) {
        DesignHashMap hashMap = new DesignHashMap();
        int[] keys = {5, 2069, 2070, 2073, 4138, 2068};
        int[] values = {100, 200, 400, 500, 1000, 5000};
        String[] operations = {"Get", "Get", "Put", "Get", "Put", "Get", "Get", "Remove", "Get", "Get", "Remove", "Get"};
        int[][] operationKeys = {
            {5}, {2073}, {2073, 250}, {2073},
            {121, 110}, {121}, {2068}, {2069}, {2069},
            {2071}, {2071}, {2071},
        };

        // Initialize the hash map with initial keys and values
        for (int i = 0; i < keys.length; i++) {
            hashMap.put(keys[i], values[i]);
        }

        // Execute the operations
        for (int i = 0; i < operations.length; i++) {
            String op = operations[i];
            switch (op) {
                case "Put":
                    System.out.printf("%d.\tPut(%d, %d)\n", i + 1, operationKeys[i][0], operationKeys[i][1]);
                    hashMap.put(operationKeys[i][0], operationKeys[i][1]);
                    break;
                case "Get":
                    System.out.printf("%d.\tGet(%d)\n", i + 1, operationKeys[i][0]);
                    System.out.printf("\tValue returned: %d\n", hashMap.get(operationKeys[i][0]));
                    break;
                case "Remove":
                    System.out.printf("%d.\tRemove(%d)\n", i + 1, operationKeys[i][0]);
                    hashMap.remove(operationKeys[i][0]);
                    break;
            }

            // Print the current state of the hash map
            System.out.println("\nCurrent Hash Map:");
            hashMap.printHashMap();
            System.out.println("-".repeat(100));
        }
    }
}
