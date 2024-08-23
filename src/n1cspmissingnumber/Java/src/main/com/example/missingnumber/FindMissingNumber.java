// File: FindMissingNumber.java

package src.main.com.example.missingnumber;

public class FindMissingNumber {

    public int findMissingNumber(int[] nums) {
        int lenNums = nums.length;
        int index = 0;

        while (index < lenNums) {
            int value = nums[index];

            if (value < lenNums && value != nums[value]) {
                // Swap nums[index] and nums[value]
                int temp = nums[index];
                nums[index] = nums[value];
                nums[value] = temp;
            } else {
                index++;
            }
        }

        for (int i = 0; i < lenNums; i++) {
            if (i != nums[i]) {
                return i;
            }
        }
        return lenNums;
    }
}
