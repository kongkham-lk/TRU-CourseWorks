import java.util.Arrays;
import java.util.Stack;

public class BinaryArrayTree {

    private Integer[] nodeList;
    private final static int DEFAULT_CAPACITY = 16;

    public BinaryArrayTree() {
        nodeList = new Integer[DEFAULT_CAPACITY];
    }

    // Print out nodes as level order
    public String toString() {
        String result = "";
        for (int i = 0; i < nodeList.length; i++) {
            if (nodeList[i] != null)
                result += nodeList[i] + " ";
        }
        return result;
    }

    public void insert(int item) {
        int curr = 0; // root node
        int level = 0;

        // for the very first added item
        if (nodeList[curr] == null)
            nodeList[curr] = item;
        else {
            // determined which subTree to go, keep checking till leaf
            while (nodeList[curr] != null) {
                if (item < nodeList[curr])
                    curr = 2 * curr + 1;
                else
                    curr = 2 * curr + 2;

                level++;

                // expand the size of nodeList
                if (curr >= nodeList.length) {
                    int newSize = (int) Math.pow(curr, level);
                    nodeList = Arrays.copyOf(nodeList, newSize);
                }
            }
        }

        nodeList[curr] = item;
    }

    // Print out nodes as pre-order
    public String toString2() {
        String result = "";
        Stack<Integer> stack = new Stack<>();
        stack.push(0);
        while (!stack.isEmpty()) {
            int curr = stack.pop();
            if (nodeList[curr] != null)
                result += nodeList[curr] + " ";
                
            int lChild = 2 * curr + 1;
            int rChild = lChild + 1;
            if (rChild < nodeList.length && nodeList[rChild] != null)
                stack.push(rChild);
            if (lChild < nodeList.length && nodeList[lChild] != null)
                stack.push(lChild);
        }
        return result;
    }
}
