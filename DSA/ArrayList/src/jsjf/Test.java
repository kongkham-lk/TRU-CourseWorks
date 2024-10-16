package jsjf;

import java.util.Iterator;

public class Test {
    public static void main(String[] args) {
        int size = 3;
        Integer[] inputs = new Integer[] { 4, 2, 1, 6 };
        System.out.println("\nInputs sample: " + grabAllElFromArray(inputs));

        System.out.println("\n------------- Test ArrayUnorderedList's method!!! -------------\n");

        // initialized with only size of 3 in order to test expandCapacity method when add
        ArrayUnorderedList<Integer> unorderedList = new ArrayUnorderedList<>(size);

        System.out.println("Initial list's el:                  " + unorderedList);
        System.out.println("Initial list size:                  " + unorderedList.size());
        System.out.println("isEmpty:                            " + unorderedList.isEmpty() + "\n");

        int i;
        for (i = 0; i < size; i++)
            unorderedList.addToRear(inputs[i]);
        System.out.println("Add first 3 - addToRear():          " + unorderedList);

        for (; i < inputs.length; i++)
            unorderedList.addToFront(inputs[i]);
        System.out.println("Add last el - addToFront():         " + unorderedList);

        unorderedList.addAfter(3, 2);
        System.out.println("Add 3 after 2 - addAfter:           " + unorderedList);
        System.out.println("Curr total el in the list:          " + unorderedList.size());

        testArrayListLogic(unorderedList, inputs, 10);

        System.out.println("\n----------- Test ArrayOrderedList's method !!! -----------\n");

        // initialized with only size of 3 in order to test expandCapacity method when add
        ArrayOrderedList<Integer> orderedList = new ArrayOrderedList<>(size);

        System.out.println("Initial list's el:                  " + unorderedList);
        System.out.println("Initial list size:                  " + unorderedList.size());
        System.out.println("isEmpty:                            " + unorderedList.isEmpty() + "\n");

        for (i = 0; i < inputs.length; i++)
            orderedList.add(inputs[i]);
        System.out.println("Add last el - add():                " + orderedList + "\n");
        System.out.println("find 1:                             " + orderedList.find(1));
        System.out.println("find 2:                             " + orderedList.find(2));
        System.out.println("find 4:                             " + orderedList.find(4));
        System.out.println("find 6:                             " + orderedList.find(6));
        System.out.println("find 5:                             " + orderedList.find(5) + "\n");
        testArrayListLogic(orderedList, inputs, 10);
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

    /**
     * Helper function for testing all the ArrayStack's and DroupOutArrayStack's
     * methods
     * 
     * @param <T>
     * @param targetList
     * @param inputs
     * @param size
     */
    private static <T> void testArrayListLogic(ArrayList<T> targetList, T[] inputs, T invaldInput) {
        System.out.println("Check First():                      " + targetList.first());
        System.out.println("Check Last():                       " + targetList.last() + "\n");
        System.out.println("Contains " + inputs[2] + "?                         " + targetList.contains(inputs[2])
                + " -> Expected: True"); // Valid input
        System.out.println("Contains " + invaldInput + "?                        " + targetList.contains(invaldInput)
                + " -> Expected: False"); // Invalid input
        System.out.println("isEmpty:                            " + targetList.isEmpty() + "\n");
        System.out
                .println("removeFirst():                      " + targetList.removeFirst() + " -> left: " + targetList);
        System.out
                .println("removeLast():                       " + targetList.removeLast() + " -> left: " + targetList);
        System.out.println(
                "remove():                           " + targetList.remove(inputs[1]) + " -> left: " + targetList);
        System.out.println("Curr total el in the list:          " + targetList.size() + "\n");

        System.out.println(">>> Test Iterator Logic");
        Iterator<T> targetIteratorList = targetList.iterator();
        System.out.println("hasNext():                          " + targetIteratorList.hasNext());
        System.out.println("next():                             " + targetIteratorList.next());

        System.out.print("remove all el:                      ");
        for (int i = targetList.size() - 1; i >= 0; i--)
            System.out.print(targetList.removeFirst() + " ");

        System.out.println("\nleft el after remove:               " + targetList);
        System.out.println("\nCurr total el in the list:          " + targetList.size());
        System.out.println("isEmpty:                            " + targetList.isEmpty());
    }
}