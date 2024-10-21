package jsjf;

import jsjf.exceptions.ElementNotFoundException;
import jsjf.exceptions.EmptyCollectionException;
import jsjf.exceptions.NonComparableElementException;

public class OrderedLinkedList<T> {
    private LinearNode<T> head;

    public OrderedLinkedList() {
        head = null;
        rear = null;
    }

    public void add(T element) {
        LinearNode<T> newNode = new LinearNode<>(element);

        // add for the very first time
        if (head == null)
            head = newNode;
            
        if (!(element instanceof Comparable))
            throw new NonComparableElementException("OrderedLinkedList");

        LinearNode<T> curr = head;
        Comparable<T> compareElement = (Comparable<T>)element;

        if (compareElement.compareTo(head.getElement()) <= 0) { // found the new smallest value as new head
            newNode.setNext(head);
            head = newNode;
        } else {
            while (compareElement.compareTo(curr.getElement()) <= 0 && curr.getNext() != null)
                curr = curr.getNext();

            if (curr.getNext() != null) {
                newNode.setNext(curr.getNext());
                curr.setNext(newNode);
            }
            else { // add to the back
                newNode.setNext(curr.getNext());
                curr.setNext(newNode);
            }
        }
    }

    public void delete(T element) throws EmptyCollectionException, NonComparableElementException, ElementNotFoundException {
        if (head == null)
            throw new EmptyCollectionException("OrderedLinkedList");

        if (!(element instanceof Comparable))
            throw new NonComparableElementException("OrderedLinkedList");

        LinearNode<T> curr = head;
        Comparable<T> compareElement = (Comparable<T>)element;

        while (compareElement.compareTo(curr.getNext().getElement()) != 0 && curr.getNext() != null)
            curr = curr.getNext();

        if (curr == null)
            throw new ElementNotFoundException("OrderedLinkedList");
        
        // curr
    }
}
/*
-	constructor
-	add
-	toString
-	delete
 */