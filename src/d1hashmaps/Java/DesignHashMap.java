import java.util.ArrayList;
import java.util.List;

public class DesignHashMap {
    private int keySpace;
    private List<Bucket> buckets;

    public DesignHashMap() {
        this.keySpace = 2069;
        this.buckets = new ArrayList<>();
        for (int i = 0; i < keySpace; i++) {
            this.buckets.add(new Bucket());
        }
    }

    public void put(int key, int value) {
        int hashKey = key % keySpace;
        buckets.get(hashKey).update(key, value);
    }

    public int get(int key) {
        int hashKey = key % keySpace;
        return buckets.get(hashKey).get(key);
    }

    public void remove(int key) {
        int hashKey = key % keySpace;
        buckets.get(hashKey).remove(key);
    }

    // For printing the current state of the hash map
    public void printHashMap() {
        for (int i = 0; i < buckets.size(); i++) {
            List<Pair> pairs = buckets.get(i).getPairs();
            if (pairs.size() > 0) {
                System.out.print("Bucket " + i + ": ");
                for (Pair pair : pairs) {
                    System.out.print("{key: " + pair.key + ", value: " + pair.value + "} ");
                }
                System.out.println();
            }
        }
    }
}
