public class Main {
    public static void main(String[] args) {
        String[] inputs = {
                "g",
                "ggaabcdeb",
                "abbddaccaaabcd",
                "aannkwwwkkkwna",
                "abbabccblkklu"
        };

        for (int i = 0; i < inputs.length; i++) {
            String input = inputs[i];
            System.out.println((i + 1) + ".\tRemove duplicates from string: \"" + input + "\"");
            String resultingString = RemoveDuplicatesHelper.removeDuplicates(input);
            System.out.println("\tString after removing duplicates: \"" + resultingString + "\"");
            System.out.println(new String(new char[100]).replace('\0', '-'));
        }
    }
}
