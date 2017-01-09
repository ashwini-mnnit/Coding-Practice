#include "stdafx.h"
#include "List.hpp"
#include <memory>

void ListOperations::printLinkedlist(SingleLinkedList *head) {

	while (head)
	{
		cout << head->value << "->";
		head = head->next;
	}

	cout << "NULL" << endl;
}

void  ListOperations::reverseLinkedList(SingleLinkedList** head) {

	SingleLinkedList *prev = NULL;
	SingleLinkedList *current = *head;
	SingleLinkedList *next = NULL;
	while (current != NULL) {
		next = current->next;
		current->next = prev;
		prev = current;
		current = next;
	}

	*head = prev;
}

SingleLinkedList* ListOperations::getMiddleElement(SingleLinkedList head) {
	SingleLinkedList	*slow, *fast;
	slow = fast = &head;

	while (slow && fast && fast->next)
	{
		slow = slow->next;
		fast = fast->next;
		if (fast->next)
			fast = fast->next;
	}

	return slow;
}


SingleLinkedList* ListOperations::alternateMerge(SingleLinkedList* list1, SingleLinkedList* list2) {

	SingleLinkedList* rv = list1;

	while (list1 && list2) {

		SingleLinkedList *nextNode = list1->next;

		list1->next = list2;
		list2 = list2->next;

		list1->next->next = nextNode;
		list1 = nextNode;
	}

	if (list2)
		list1->next = list2;

	return rv;
}

void ListOperations::PerformShuffle(SingleLinkedList** head) { // make it inplace
	SingleLinkedList* rv = *head;

	SingleLinkedList* middle = getMiddleElement(**head);

	SingleLinkedList* list2 = middle->next;

	middle->next = NULL;
	reverseLinkedList(&list2);
	alternateMerge(*head, list2);
}