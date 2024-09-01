package o1tkeklargestnumber.Java.src.test.com.example;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class KthLargestTest {
    
    @Test
    public void testKthLargest() {
        int[] nums = {3, 6, 9, 10};
        KthLargest kthLargest = new KthLargest(3, nums);
        
        assertEquals(6, kthLargest.add(4));
        assertEquals(7, kthLargest.add(7));
        assertEquals(9, kthLargest.add(10));
        assertEquals(9, kthLargest.add(8));
        assertEquals(10, kthLargest.add(15));
    }
}