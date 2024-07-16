import java.util.ArrayList;
import java.util.List;

public class Bucket {
    private List<Pair> pairs;

    public Bucket() {
        this.pairs = new ArrayList<>();
    }

    public int get(int key) {
        for (Pair pair : pairs) {
            if (pair.key == key) {
                return pair.value;
            }
        }
        return -1; // Return -1 if the key does not exist
    }

    public void update(int key, int value) {
        for (Pair pair : pairs) {
            if (pair.key == key) {
                pair.value = value;
                return;
            }
        }
        pairs.add(new Pair(key, value));
    }

    public void remove(int key) {
        for (int i = 0; i < pairs.size(); i++) {
            if (pairs.get(i).key == key) {
                pairs.remove(i);
                return;
            }
        }
    }
}
