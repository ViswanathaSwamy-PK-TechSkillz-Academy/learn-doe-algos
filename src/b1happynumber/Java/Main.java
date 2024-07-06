public class Main {

    public static void main(String[] args) {
        int[] inputs = { 1, 5, 19, 25, 7 };

        for (int input : inputs) {
            System.out.println("Input Number: " + input);
            System.out.println("Is it a happy number? " + HappyNumberHelper.isHappyNumber(input));
            System.out.println("-".repeat(50));
        }
    }
}
