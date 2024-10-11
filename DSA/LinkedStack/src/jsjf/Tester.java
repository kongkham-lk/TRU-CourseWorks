package jsjf;

public class Tester {
    public static void main(String[] args) {
        Integer[] initialInputs = { 10, 20, 30, 40, 50, 60 };
        System.out.println("\nInputs sample: " + grabAllElFromArray(initialInputs));

        System.out.println("\n------------- Test LinkedStack's method!!! -------------\n");
        LinkedStack<Integer> linkedStack = new LinkedStack<>();
        testLogic(linkedStack, initialInputs);

        System.out.println("\n--------- Test DropOutLinkedStack's method !!! -----------\n");
        int limitCount = 3;
        DropOutLinkedStack<Integer> dropOutLinkedStack = new DropOutLinkedStack<>(limitCount);
        System.out.println("Limit node's count to:    " + limitCount + "\n");
        testLogic(dropOutLinkedStack, initialInputs);
    }

    /**
     * Helper function for testing all the ArrayStack's and DroupOutArrayStack's methods
     * 
     * @param <T>
     * @param node
     * @param initialInputs
     * @param size
     */
    private static <T> void testLogic(StackADT<T> node, T[] initialInputs) {
        System.out.println("Initial node has el:      " + node);
        System.out.println("Initial node's count:     " + node.size());
        System.out.println("isEmpty:                  " + node.isEmpty() + "\n");
        for (int i = 0; i < initialInputs.length; i++) {
            node.push(initialInputs[i]);
            System.out.println("Update Push:              " + node);
        }
        System.out.println("\nTotal count are:          " + node.size());
        System.out.println("Peek:                     " + node.peek() + "\n");
        System.out.println("Pop one el:               " + node.pop());
        System.out.println("After Pop, count are:     " + node.size());
        System.out.println("After Pop, remain el:     " + node);
        System.out.println("Peek:                     " + node.peek());
        System.out.println("isEmpty:                  " + node.isEmpty());
        System.out.print("Pop all the remain el:    ");
        while (node.size() > 0) {
            System.out.print(node.pop() + ", ");
        }
        System.out.println("\nCount are:                " + node.size());
        System.out.println("The remaining el are:     " + node);
        System.out.println("Peek:                     " + node.peek());
        System.out.println("isEmpty:                  " + node.isEmpty());
    }

    /**
     * Helper function for grabing all the element of an array
     * 
     * @param inputs
     * @return
     */
    private static String grabAllElFromArray(Integer[] inputs) {
        String result = "";

        for (int i = 0; i < inputs.length; i++)
            result += inputs[i] + " ";

        return result;
    }
}