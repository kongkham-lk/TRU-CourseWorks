package jsjf;

public class Tester {
    public static void main(String[] args) {
        Integer[] initialInputs = { 10, 8, 6, 4, 2, 1, 3, 5, 7, 9, 0, 11 };
        System.out.println("\nInputs sample: " + grabAllElFromArray(initialInputs));

        System.out.println("\n--------- Test OrderedLinkedList's method !!! -----------\n");
        OrderedLinkedList<Integer> orderedLinkedList = new OrderedLinkedList<>();
        System.out.println("Initial node has el:            " + orderedLinkedList + "\n");
        for (int i = 0; i < initialInputs.length - 2 ; i++) {
            orderedLinkedList.add(initialInputs[i]);
            System.out.println("Push " + initialInputs[i] + ":                     " + orderedLinkedList);
        }
        System.out.println("\nAdded new largest value:    11 ");
        orderedLinkedList.add(initialInputs[initialInputs.length - 1]);
        System.out.println("Update el:                  " + orderedLinkedList);
        System.out.println("Added new smallest value:   0");
        orderedLinkedList.add(initialInputs[initialInputs.length - 2]);
        System.out.println("Update el:                  " + orderedLinkedList);
        System.out.println("Delete value:               4");
        orderedLinkedList.delete(initialInputs[3]);
        System.out.println("remain el:                  " + orderedLinkedList);
        System.out.println("\nDelete not existed value:   10");
        orderedLinkedList.delete(initialInputs[0]);
        System.out.println("remain el:                  " + orderedLinkedList);

        System.out.println("\n------------- Test OrderedArrayList's method!!! -------------\n");
        ArrayOrderedList<Integer> orderedArrayList = new ArrayOrderedList<>();
        System.out.println("Initial node has el:            " + orderedArrayList + "\n");
        for (int i = 0; i < initialInputs.length - 2 ; i++) {
            orderedArrayList.add(initialInputs[i]);
            System.out.println("Push " + initialInputs[i] + ":                     " + orderedArrayList);
        }
        System.out.println("\nAdded new largest value:    11 ");
        orderedArrayList.add(initialInputs[initialInputs.length - 1]);
        System.out.println("Update el:                  " + orderedArrayList + "\n  >>> Expected: no new value is added\n");
        System.out.println("Added new smallest value:   0");
        orderedArrayList.add(initialInputs[initialInputs.length - 2]);
        System.out.println("Update el:                  " + orderedArrayList + "\n  >>> Expected: 0 is added and 10 is removed\n");
        System.out.println("Delete value:               4");
        orderedArrayList.delete(initialInputs[3]);
        System.out.println("remain el:                  " + orderedArrayList);
        System.out.println("\nDelete not existed value:   10\n  >>> Expected: THROW EXCEPTION\n");
        orderedArrayList.delete(initialInputs[0]);
    }

    /**
     * Helper function for grabing all the element of an array
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