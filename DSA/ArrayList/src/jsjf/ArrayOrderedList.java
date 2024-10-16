package jsjf;

import static jsjf.ArrayList.NOT_FOUND;

import jsjf.exceptions.*;

/**
 * ArrayOrderedList represents an array implementation of an ordered list.
 *
 * @author Java Foundations
 * @version 4.0
 */
public class ArrayOrderedList<T> extends ArrayList<T> implements OrderedListADT<T>
{
	/**
	 * Creates an empty list using the default capacity.
	 */
	public ArrayOrderedList()
	{
		super();
	}

	/**
	 * Creates an empty list using the specified capacity.
	 *
	 * @param initialCapacity the initial size of the list
	 */
	public ArrayOrderedList(int initialCapacity)
	{
		super(initialCapacity);
	}

	/**
	 * Adds the specified Comparable element to this list, keeping
	 * the elements in sorted order.
	 *
	 * @param element the element to be added to the list
	 */
	public void add(T element)
	{
		if (!(element instanceof Comparable))
			throw new NonComparableElementException("OrderedList");

		Comparable<T> comparableElement = (Comparable<T>)element;

		if (size() == list.length)
			expandCapacity();

		int scan = 0;  

		// find the insertion location
		while (scan < rear && comparableElement.compareTo(list[scan]) > 0)
			scan++;

		// shift existing elements up one
		for (int shift = rear; shift > scan; shift--)
			list[shift] = list[shift - 1];

		// insert element
		list[scan] = element;
		rear++;
		modCount++;
	}

	/**
	 * Returns the array index of the specified element, or the
	 * constant NOT_FOUND if it is not found.
	 *
	 * @param target the target element
	 * @return the index of the target element, or the 
	 *         NOT_FOUND constant
	 */
	public int find(T target)
	{
		if (!(target instanceof Comparable))
			throw new NonComparableElementException("OrderedList");

		Comparable<T> comparableElement = (Comparable<T>)target;

        if (comparableElement.compareTo(list[0]) >= 0) {
            int l = 0;
            int r = rear - 1;
            while (l <= r) {
                int mid = l + (r - l) / 2;
                if (comparableElement.compareTo(list[mid]) == 0)
                    return mid;
                else if (comparableElement.compareTo(list[mid]) < 0)
                    r = mid - 1;
                else
                    l = mid + 1;
            }
        }

		return NOT_FOUND;
	}
}
