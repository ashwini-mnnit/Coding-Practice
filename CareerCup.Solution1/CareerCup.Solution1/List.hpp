#pragma once

#include <iostream>
using namespace std;

struct SingleLinkedList {

	int  value;
	SingleLinkedList* next;

	SingleLinkedList(int _val, SingleLinkedList* _next)
	{
		value = _val;
		next = _next;
	}
};

class ListOperations {

public:
	void reverseLinkedList(SingleLinkedList** head);
	SingleLinkedList* getMiddleElement(SingleLinkedList head);
	SingleLinkedList* alternateMerge(SingleLinkedList* list1, SingleLinkedList* list2);
	void insertAfterNode(SingleLinkedList &node, SingleLinkedList  &insertNode);

public:
	ListOperations() {}
	void printLinkedlist(SingleLinkedList *head);
	void PerformShuffle(SingleLinkedList** head);
};
