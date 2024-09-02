package o1tkeklargestnumber.Java.src.main.com.example;

import java.util.Arrays;

import o1tkeklargestnumber.Java.src.main.com.example.kthlargestnumber.KthLargest;

public class Main {
    public static void main(String[] args) {
        int[] nums = { 3, 6, 9, 10 };
        System.out.println("Initial stream: " + Arrays.toString(nums));
        System.out.println("k: " + 3);

        KthLargest kthLargest = new KthLargest(3, nums);
        int[] valuesToAdd = { 4, 7, 10, 8, 15 };
        for (int val : valuesToAdd) {
            System.out.println("\tAdding a new number " + val + " to the stream");
            System.out.println("\tKth largest element in the stream: " + kthLargest.add(val));
            System.out.println("--------------------------------------------------");
        }
    }
}
