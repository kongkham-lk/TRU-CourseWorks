package jsjf;

import jsjf.exceptions.EmptyCollectionException;

/**
 * An array implementation of a stack in which the bottom of the stack is fixed at index 0.
 * 
 * 
 * @author Java Foundations
 * @version 4.0
 */
public class DroupOutArrayStack<T> extends ArrayStack<T> {
    /**
     * Creates an empty stack using the default capacity.
     */
    public DroupOutArrayStack() {
        super();
    }

    /**
     * Creates an empty stack using the specified capacity.
     * 
     * @param initialCapacity the initial size of the array
     */
    public DroupOutArrayStack(int initialCapacity) {
        super(initialCapacity);
    }

    /**
     * Adds the specified element to the top of this stack, expanding
     * the capacity of the array if necessary.
     * 
     * @param element generic element to be pushed onto stack
     */
    public void push(T element) {
        // reset top to 0 when it reach the last element
        if (top == stack.length)
            top = 0;
            
        super.push(element);
    }

    /**
     * Removes the element at the top of this stack and returns a
     * reference to it.
     * 
     * @return element removed from top of stack
     * @throws EmptyCollectionException if stack is empty
     */
    public T pop() throws EmptyCollectionException {
        // move top to the end of array if there is not element at its front.
        if (top == 0)
            top = stack.length;
            
        return super.pop();
    }

    /**
     * Returns true if this stack is empty and false otherwise.
     * 
     * @return true if this stack is empty
     */
    public boolean isEmpty() {
        // cannot use top to check if stack is empty since top can point to any index, other than index 0.
        // E.g. stack.length is 3, and 5 element is push, top = 2. Then if we pop all the elements out of the stack,
        // pop all 3 elements, top will be still point to index 2.
        for (int i = 0; i < stack.length; i++) {
            if (stack[i] != null)
                return false;
        }
        return true;
    }

    /**
     * Returns a string representation of this stack.
     * 
     * @return a string representation of the stack
     */
    public String toString() {
        String result = "";
        // Since using the concept of circular array, which Top can come before the oldest element.
        // In order to print out the right order, we need 2 for loop to do the task. 
        // e.g. let Top = 2 and stack size is 5, the first iteration will start from Top-1 to the index 0, 
        // then start from the end of stack to Top. 
        for (int i = top - 1; i >= 0; i--) {
            if (stack[i] == null)
                continue;
            result += stack[i] + " ";
        }
        for (int i = stack.length - 1; i >= top; i--) {
            if (stack[i] == null)
                continue;
            result += stack[i] + " ";
        }

        return result;
    }
}
