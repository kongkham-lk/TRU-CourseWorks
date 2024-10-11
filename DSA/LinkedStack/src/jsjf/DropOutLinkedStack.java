package jsjf;

/**
 * Represents a linked implementation of a stack.
 *
 * @author Java Foundations 
 * @version 4.0
 */
public class DropOutLinkedStack<T> extends LinkedStack<T>
{
    private static int limitCount = 100;

	/**
	 * Creates an empty stack.
	 */
	public DropOutLinkedStack()
	{
        this(limitCount);
	}

	/**
	 * Creates an empty stack.
	 */
	public DropOutLinkedStack(int limitCount_in)
	{
        super();
        limitCount = limitCount_in;
	}

	/**
	 * Adds the specified element to the top of this stack.
	 * @param element element to be pushed on stack
	 */
	public void push(T element)
	{
        if (limitCount <= 0) // do nth when limit size is zero
            return;
        else if (limitCount == 1) // if limit size set to 1, the whole Linked stack will always has 1 node
            top = null;
        else
            if (count == limitCount) {
                LinearNode<T> curr = top;
        
                while (curr.getNext().getNext() != null) {
                    curr = curr.getNext();
                }
                curr.setNext(null);
                count--;
            }
        super.push(element);
	}
}
