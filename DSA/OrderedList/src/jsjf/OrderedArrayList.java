package jsjf;

import jsjf.exceptions.ElementNotFoundException;
import jsjf.exceptions.EmptyCollectionException;
import jsjf.exceptions.NonComparableElementException;

/**
 * An Order list that implement with Array structure.
 * 
 * @author Kongkham Luangkhot
 * @version 5.0
 */
public class OrderedArrayList<T> {
    private int maxSize = 10;
    private T[] list;
    private int pushElementsCount;

    public OrderedArrayList() {
        list = (T[]) new Object[maxSize];
        pushElementsCount = 0;
    }

    public void add(T element) throws NonComparableElementException {
        // Added to the front right away for the very first time added new element
        if (pushElementsCount == 0)
            list[pushElementsCount] = element;

        if (!(element instanceof Comparable))
			throw new NonComparableElementException("OrderedArrayList");

        Comparable<T> comparableElement = (Comparable<T>)element;
        int targetIndex = 0;

        // Finding the right index order of the element
        while (targetIndex < pushElementsCount && comparableElement.compareTo(list[targetIndex]) > 0)
            targetIndex++;

        // if all the element is filled and trying to add larget value element to the list, 
        // the list should remain the same.
        if (targetIndex != maxSize) {
            // if added as the new last element
            if (targetIndex == pushElementsCount)
                list[pushElementsCount] = element;
            else if (targetIndex < pushElementsCount) { // added in the middle of the list
                // shift all the element to the right before insert the new element
                for (int i = pushElementsCount; i > targetIndex; i--)
                    list[i] = list[i-1];
                list[targetIndex] = element;
            }
            if (pushElementsCount < maxSize-1)
                pushElementsCount++;
        }
    }

    public void delete(T element) throws EmptyCollectionException, NonComparableElementException, ElementNotFoundException {
        // notify when the list is empty
        if (pushElementsCount == 0)
            throw new EmptyCollectionException("OrderedArrayList");

        if (!(element instanceof Comparable))
			throw new NonComparableElementException("OrderedArrayList");

        // find the right index to remove
        Comparable<T> comparableElement = (Comparable<T>)element;
        int targetIndex = 0;

        while (targetIndex <= pushElementsCount && comparableElement.compareTo(list[targetIndex]) != 0)
            targetIndex++;

        if (targetIndex >= pushElementsCount)
            throw new ElementNotFoundException("OrderedArrayList");
        else {
            while (targetIndex < pushElementsCount) {
                list[targetIndex] = list[targetIndex+1];
                targetIndex++;
            }
            list[pushElementsCount] = null;
            pushElementsCount--;
        }
    }

    public String toString() {
        String result = "";

        for (int i = 0; i < pushElementsCount; i++)
            result += list[i] + " ";
            
        return result;
    }
}