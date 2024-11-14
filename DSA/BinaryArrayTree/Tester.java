import java.util.Arrays;

public class Tester {

    public static void main(String[] args) {
        int[] inputs = { 45, 69, 51, 12, 7, 15, 42, 14, 70, 81 };

        BinaryArrayTree BST = new BinaryArrayTree();
        for (int input : inputs)
            BST.insert(input);

        System.out.print("\nInput sample: ");
        System.out.println(Arrays.toString(inputs));
        System.out.println("\nPrintout nodes as LeveOrder:");
        System.out.println(BST.toString());
        System.out.println("\nPrintout nodes as PreOrder:");
        System.out.println(BST.toString2() + "\n");
    }
}
